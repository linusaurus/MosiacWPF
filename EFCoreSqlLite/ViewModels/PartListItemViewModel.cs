using Mosiac.Events;
using Prism.Commands;
using Prism.Events;
using System.Windows.Input;

namespace Mosiac.ViewModels
{
    class PartListItemViewModel : ViewModelBase
    {
        private string _displayMember;
        private IEventAggregator _eventAggregator;

        public PartListItemViewModel(int id, string displayMember,
          IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Id = id;
            DisplayMember = displayMember;
            OpenPartDetailView = new DelegateCommand(OnOpenPartDetailView);
        }

        public int Id { get; }

        public string DisplayMember
        {
            get { return _displayMember; }
            set {
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenPartDetailView { get; }

        private void OnOpenPartDetailView()
        {
            _eventAggregator.GetEvent<OpenPartDetailEvent>()
                  .Publish(Id);
        }
    }

}
