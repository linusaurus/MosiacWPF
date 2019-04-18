using BadgerData.DTO;
using Database.DTO;
using Database.Models;
using Microsoft.Win32;
using Mosiac.Events;
using Mosiac.Repository;
using Mosiac.Services;
using Mosiac.Wrapper;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private readonly IPartRepository _partRepository;

        public PartDetailViewModel(IPartService partService,IPartRepository partRepository,
            IEventAggregator eventAggregator,
            IManufacturerLookupService manuLookup,ISupplierLookupDataService supplierLookupDataService, ILookupUnitsOfMeasure unitsOfMeasureLookup)
        {
            ///TODO  replace with single repository
            ///
    
            _partService = partService;
            _partRepository = partRepository;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenPartDetailEvent>().Subscribe(OnOpenPartDetailView);
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
            NewResource = new DelegateCommand<object>(OnNewResourceExecute, OnNewResourceCanExecute);
            EditResource = new DelegateCommand<object>(OnEditResourceExecute, OnEditResourceCanExecute);
            AttachResource = new DelegateCommand<object>(OnAttachResourceExecute, OnAttachResourceCanExecute);
            DetachResource = new DelegateCommand<object>(OnDetachResourceExecute, OnDetachResourceCanExecute);
          

    }

        /// <summary>
        /// Public exposed collections
        /// </summary>
        public ObservableCollection<Document> PartResources { get; set; }
        public ObservableCollection<PurchaseOrderListDTO> PartOrders { get; set; }
        public ObservableCollection<InventoryTransactionsDTO> PartTransactions { get; set; }

        /// <summary>
        /// Commands
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        /// 

        private bool OnDetachResourceCanExecute(object arg)
        {return true; }

        private void OnDetachResourceExecute(object obj)
        {
            throw new NotImplementedException();
        }

        private bool OnAttachResourceCanExecute(object arg)
        { return true; }
           
        private void OnAttachResourceExecute(object obj)
        {
            throw new NotImplementedException();
        }
        private bool OnEditResourceCanExecute(object arg)
        {return true; }

        private void OnEditResourceExecute(object obj)
        {
            ;
        }

        private bool OnNewResourceCanExecute(object arg)
        {
            return true;
        }

        private void OnNewResourceExecute(object obj)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
            }
  
            var newdoc = new Document() ;
            newdoc.PartID = DetailPart.Id;
            newdoc.DocumentView = "Drawing";
            newdoc.Description = "Blah, Blah,Blah";
            newdoc.DocumentPath = ".txt";
           _partService.AddPartResources(newdoc);
            
        }

   
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
                if (File.Exists(path))
                {  System.Diagnostics.Process.Start(path); }                 
                else
                {
                    MessageBox.Show("File does not exist");
                }
               
            }
            
        }

        

        public bool OnOpenResourceCanExecute(object parameter)
        {return true;}
 
        private bool OnSaveCanExecute()
        {return true; }
            
        private async void OnSaveExecute()
        {
            await _partService.Save(DetailPart.Model);
            _eventAggregator.GetEvent<AfterPartSavedEvent>().Publish(
                new AfterPartSavedEventArgs
               {
                Id = DetailPart.Id,
                DisplayMember = DetailPart.ItemDescription
                });
        }

        private async void OnOpenPartDetailView(int partID)
        {
           await LoadAsync(partID);
        }

        public async Task LoadAsync(int partID)
        {
           
            //DetailPart = await _partService.GetPart(partID);

            var part = await _partService.GetPart(partID);
            DetailPart = new PartWrapper(part);
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
        /// <summary>
        /// Public Exposed Collections of Lookups
        /// </summary>
        public ObservableCollection<LookupItem> ManusList { get; set; }
        public ObservableCollection<LookupItem> SuppliersList { get; set; }
        public ObservableCollection<LookupItem> UnitsOfMeasureList { get; set; }

        private PartWrapper part;

        public PartWrapper DetailPart
        {
            get { return part; }
            set {
                part = value;
                OnPropertyChanged();
            }
        }

       

        public ICommand SaveCommand { get; }
        public ICommand OpenResource { get; }
        public ICommand NewResource { get; }
        public ICommand EditResource { get; }
        public ICommand AttachResource { get; }
        public ICommand DetachResource { get; }
        public ICommand OpenPurchaseOrder { get; }
        
    }
}
