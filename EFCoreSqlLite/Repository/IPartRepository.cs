using System.Collections.Generic;
using System.Threading.Tasks;
using Database.DTO;
using Database.Models;

namespace Mosiac.Repository
{
    public interface IPartRepository
    {

        Task<Part> GetByIdAsync(int partID);
        bool HasChanges();
        Task SaveAsync();
        
    }
}