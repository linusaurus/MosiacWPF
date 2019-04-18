using System.Collections.Generic;
using System.Threading.Tasks;
using Database.DTO;
using Database.Models;

namespace Mosiac.Services
{
    public interface IPartService
    {
        void Add(Part obj);
        void Delete(int partID);
        void AddPartResources(Document doc);
        Task<IList<Part>> GetAllAsync();
        Task<Part> GetPart(int partID);
        Task<IList<Part>> Search(string term);
        Task Save(Part part);
        Task<List<Document>> GetPartResources(int partID);
        Task<List<PurchaseOrderListDTO>> GetPartOrders(int partID);
        Task<List<InventoryTransactionsDTO>> GetPartTransactionAsync(int partID);
    }
}