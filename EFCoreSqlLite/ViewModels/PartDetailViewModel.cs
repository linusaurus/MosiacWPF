using BadgerData.DTO;
using Database.DTO;
using Database.Models;
using Mosiac.Events;
using Mosiac.Services;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mosiac.ViewModels
{
    public class PartDetailViewModel : ViewModelBase, IPartDetailViewModel
    {
        private readonly IPartService _partService;
        private readonly IEventAggregator _eventAggregator;
        private readonly IManufacturerLookupService _manuLookup;
        private readonly ISupplierLookupDataService _supplierLookupDataService;
        private readonly ILookupUnitsOfMeasure _unitOfMeasureLookup;
        

        public PartDetailViewModel(IPartService partService,
            IEventAggregator eventAggregator,
            IManufacturerLookupService manuLookup,ISupplierLookupDataService supplierLookupDataService, ILookupUnitsOfMeasure unitsOfMeasureLookup)
        {
            _partService = partService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenPartDetailEvent>()
                .Subscribe(OnOpenPartDetailView);
            _manuLookup  = manuLookup;
            ManusList = new ObservableCollection<LookupItem>();
            SuppliersList = new ObservableCollection<LookupItem>();
            UnitsOfMeasureList = new ObservableCollection<LookupItem>();
            PartResources = new ObservableCollection<Document>();
            PartOrders = new ObservableCollection<PurchaseOrderListDTO>();
            PartTransactions = new ObservableCollection<InventoryTransactionsDTO>();
            _supplierLookupDataService = supplierLookupDataService;
            _unitOfMeasureLookup = unitsOfMeasureLookup;
            //- Commands
            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
            OpenResource = new DelegateCommand<object>(OnOpenResourceExecute, OnOpenResourceCanExecute);  
        }
        /// <summary>
        /// Public exposed collections
        /// </summary>
        public ObservableCollection<Document> PartResources { get; set; }
        public ObservableCollection<PurchaseOrderListDTO> PartOrders { get; set; }
        public ObservableCollection<InventoryTransactionsDTO> PartTransactions { get; set; }


        /// <summary>
        /// Open Document in default application
        /// </summary>
        /// <param name="parameter"></param>
        public void OnOpenResourceExecute(object parameter)
        {
            if (parameter != null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append (@"\\FileServer\NETSHARE2\Production\Syms\");
                sb.Append(((Document)parameter).DocID.ToString());
                sb.Append(((Document)parameter).DocumentPath.ToString());
                string path = sb.ToString();
                System.Diagnostics.Process.Start(path);
            }
            
        }

        public bool OnOpenResourceCanExecute(object parameter)
        {return true;}
 
        private bool OnSaveCanExecute()
        {return true; }
            
        private async void OnSaveExecute()
        {
            await _partService.Save(DetailPart);
            _eventAggregator.GetEvent<AfterPartSavedEvent>().Publish(
                new AfterPartSavedEventArgs
               {
                Id = DetailPart.PartID,
                DisplayMember = DetailPart.ItemDescription
                });
        }

        private async void OnOpenPartDetailView(int partID)
        {
            await LoadAsync(partID);
        }

        public async Task LoadAsync(int partID)
        {
            DetailPart = await _partService.GetPart(partID);
            // Load Resources---------------------------------------
            var result = await _partService.GetPartResources(partID);
            if (result != null)
            {
                PartResources.Clear();
                foreach (var item in result)
                {
                    PartResources.Add(item);
                }
            }
           
            // Load Orders------------------------------------------
            var orders = await _partService.GetPartOrders(partID);
            if (orders != null)
            {
                PartOrders.Clear();
                foreach (var order in orders)
                {
                    PartOrders.Add(order);
                }

            }
            
            // Load Inventory History --------------------------------
            var trans = await _partService.GetPartTransactionAsync(partID);
            if (trans != null)
            {
                PartTransactions.Clear();
                foreach (var tran in trans)
                {
                    PartTransactions.Add(tran);
                }

            }
            
                

        }

        public async Task LoadManusList()
        {
            var   col = await _manuLookup.GetManufacturerLookupAsync();
            ManusList.Clear();
            foreach (var item in col)
            {
                ManusList.Add(item);
            }
        }

        public async Task LoadSuppliersList()
        {
            var col = await _supplierLookupDataService.GetSupplierLookupAsync();
            SuppliersList.Clear();
            foreach (var item in col)
            {
                SuppliersList.Add(item);
            }
        }

        public async Task LoadUnitsOfMeasureList()
        {
            var col = await _unitOfMeasureLookup.GetUnitsOfMeasureLookupAsync();
            UnitsOfMeasureList.Clear();
            foreach (var item in col)
            {
                UnitsOfMeasureList.Add(item);
            }
        }

        public ObservableCollection<LookupItem> ManusList { get; set; }
        public ObservableCollection<LookupItem> SuppliersList { get; set; }
        public ObservableCollection<LookupItem> UnitsOfMeasureList { get; set; }


        private Part part;

        public Part DetailPart
        {
            get { return part; }
            set {
                part = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }
        public ICommand OpenResource { get; }
    }
}
