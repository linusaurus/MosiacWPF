using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using BadgerData.DTO;
using Database.DTO;
using Database.Models;
using Prism.Commands;

namespace Mosiac.ViewModels
{
    public interface IPartDetailViewModel
    {
        Part DetailPart { get; set; }
        ObservableCollection<Document> PartResources { get; set; }
        ObservableCollection<PurchaseOrderListDTO> PartOrders { get; set; }
        ObservableCollection<InventoryTransactionsDTO> PartTransactions { get; set; }
        Task LoadManusList();
        Task LoadSuppliersList();
        Task LoadAsync(int partID);
        Task LoadUnitsOfMeasureList();
        
        
    }
}