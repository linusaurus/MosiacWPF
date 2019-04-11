using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Models;

namespace Mosiac.Services
{
    public interface IPartTypeLookup
    {
        Task<IEnumerable<LookupItem>> GetPartTypeLookupAsync(int partCategoryID);
    }
}