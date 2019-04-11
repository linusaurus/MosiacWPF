using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Database.Models;

namespace Mosiac.Services
{
    public interface IManufacturerLookupService
    {
       Task<IEnumerable<LookupItem>> GetManufacturerLookupAsync();
    }
}