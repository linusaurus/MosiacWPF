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

namespace Mosiac.Services
{
    public class PartService : IPartService
    {
        private DatabaseContext _ctx;

        public PartService(Database.DatabaseContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Part obj)
        {
            //inserts record in the DB via DAL
        }


        public async Task<List<Document>> GetPartResources(int partID)
        {
            return await _ctx.Document.AsNoTracking().Where(p => p.PartID == partID).ToListAsync();

        }
        public void AddPartResources(Document doc)
        {
             _ctx.Document.Add(doc);
            _ctx.SaveChanges();


        }

        public async Task<IList<Part>> Search(string term)
        {
            if (int.TryParse(term, out int result))
            {
                return await _ctx.Part.AsNoTracking().Where(d => d.PartID == result).ToListAsync();
            }
            else
            {
                return await _ctx.Part.AsNoTracking().Where(d => d.ItemDescription.Contains(term)).ToListAsync();
            }
        }

        public async Task<IList<Part>> GetAllAsync()
        {
            return await _ctx.Part.AsNoTracking().ToListAsync();
        }

        public async Task<Part> GetPart(int partID)
        {
            return await _ctx.Part.FindAsync(partID);
        }

        public void Update(Part part)
        {
            _ctx.SaveChanges();
        }

        public void Delete(int partID)
        {
            // deletes record from the DB
        }

        public void Update(PartDetailDTO dto)
        {
            throw new NotImplementedException();
        }

        public async Task Save(Part part)
        {
            _ctx.Part.Add(part);
            _ctx.Entry(part).State = EntityState.Modified;
            await _ctx.SaveChangesAsync();

        }

        public async Task<List<InventoryTransactionsDTO>> GetPartTransactionAsync(int partID)
        {
            return await _ctx.Inventory.AsNoTracking().Where(p => p.PartID == partID)
                .Select(d => new InventoryTransactionsDTO
                {
                    DateStamp = d.DateStamp.GetValueOrDefault(),
                    Description = d.Description,
                    LineID = d.LineID.GetValueOrDefault(),
                    PartID = d.PartID.GetValueOrDefault(),
                    JobName = _ctx.Job.Where(j => j.job_id ==d.JobID.GetValueOrDefault()).Select(s => s.jobname).First(),
                    Location = d.Location,
                    OrderReceiptID = d.OrderReceiptID.GetValueOrDefault(),
                    Qnty = d.Qnty.GetValueOrDefault(),
                    StockTransactionID = d.StockTransactionID,
                    TransActionType = "1",
                    UnitOfMeasure = _ctx.UnitOfMeasure.Where(u => u.UID==d.UnitOfMeasure.GetValueOrDefault()).Select(p => p.UOM).First()

                }).ToListAsync();

        }

        public async Task<List<PurchaseOrderListDTO>> GetPartOrders(int partID)
        {
            return await _ctx.PurchaseLineItem.Include(f => f.PurchaseOrder).AsNoTracking().Where(p => p.PartID == partID)
           .Select(d => new PurchaseOrderListDTO
           {
               PurchaseOrderID = d.PurchaseOrderID,
               JobName = _ctx.Job.Where(j => j.job_id == d.JobID.Value).First().jobname,
               OrderDate = d.PurchaseOrder.OrderDate.ToShortDateString(),
               OrderTotal = d.PurchaseOrder.OrderTotal.GetValueOrDefault(),
               Purchaser = d.PurchaseOrder.Employee.lastname,
               SupplierName = d.PurchaseOrder.Supplier.SupplierName,
               Received = d.Recieved.GetValueOrDefault()

           }).OrderByDescending(j => j.PurchaseOrderID).ToListAsync();
        }
    }
}
