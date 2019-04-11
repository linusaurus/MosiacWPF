using Database.Models;
using System.Collections.ObjectModel;
using Mosiac.Services;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Data;
using Mosiac.Views.Services;
using Mosiac.Events;
using Prism.Events;
using System;
using System.Linq;

namespace Mosiac.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IAssetService _assetService;
        private readonly IMessageDialogService _messageDialogService;
        private readonly IEventAggregator _eventAggregator;
   
        private Part _selectedPart;

        public IPartService _partService { get; }
        public ObservableCollection<Part> Parts { get; private set; }

        public MainViewModel(IAssetService assetService, IPartService partService,
            IMessageDialogService messageDialogService,IEventAggregator eventAggregator, IPartDetailViewModel partDetailViewModel)
        {
            Parts = new ObservableCollection<Part>();
            _assetService = assetService;
            _partService = partService;
            _messageDialogService = messageDialogService;
            _eventAggregator = eventAggregator;
            PartDetailModel = partDetailViewModel;
            _eventAggregator.GetEvent<AfterPartSavedEvent>().Subscribe(AfterPartSaved);
        }

        private void AfterPartSaved(AfterPartSavedEventArgs obj)
        {
            var lookupItem = Parts.Single(l => l.PartID == obj.Id);
            lookupItem.ItemDescription = obj.DisplayMember;
        }

        public async void Search(string term)
        {
            //TODO load partlineitem as viewModels
            var parts = await _partService.Search(term);
            Parts.Clear();
            foreach (var part in parts)
            {
                Parts.Add(part);
            }
        }
        // Load the Datasource here
        public async Task Load()
        {
            var parts = await _partService.GetAllAsync();
            Parts.Clear();
            foreach (var part in parts)
            {
                Parts.Add(part);
            }
            // Load the Manufacturer CBO List!
           await PartDetailModel.LoadManusList();
           await PartDetailModel.LoadSuppliersList();
           await PartDetailModel.LoadUnitsOfMeasureList();
           
        }

        public Part SelectedPart
        {
            get { return _selectedPart; }
            set {
                _selectedPart = value;
                OnPropertyChanged();
                if (_selectedPart!=null)
                {
                    _eventAggregator.GetEvent<OpenPartDetailEvent>()
                        .Publish(_selectedPart.PartID);
                }
            }
        }

        public IPartDetailViewModel PartDetailModel { get; }

    }
}
