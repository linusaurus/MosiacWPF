using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Models;

namespace Mosiac.Services
{
    public interface ILookupUnitsOfMeasure
    {
        Task<IEnumerable<LookupItem>> GetUnitsOfMeasureLookupAsync();
    }
}