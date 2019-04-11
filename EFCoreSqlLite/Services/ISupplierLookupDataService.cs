using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Models;

namespace Mosiac.Services
{
    public interface ISupplierLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetSupplierLookupAsync();
    }
}