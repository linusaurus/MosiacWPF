using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.DTO;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using Mosiac.Services;
using BadgerData.DTO;


namespace Mosiac.Repository
{
    public class PartRepository : IPartRepository
    {
        private DatabaseContext _context;

        public PartRepository(DatabaseContext context)
        { _context = context;}

        public async Task<Part> GetByIdAsync(int partID)
        {return await _context.Part.SingleAsync(f => f.PartID == partID);}

        public bool HasChanges()
        {return _context.ChangeTracker.HasChanges();}

        public async Task SaveAsync()
        {await _context.SaveChangesAsync(); }

    }
}
