using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Models;

namespace Mosiac.Services
{
    public class AssetService : IAssetService
    {
        public AssetService()
        {
            using (DatabaseContext dbContext = new DatabaseContext())
            {
                
            }
        }

        public ObservableCollection<Asset> GetAll()
        {
            return null;
        }

        public Asset Find(int assetID)
        {
            return new Asset();
        }

        public void Save(Asset asset)
        {

        }


    }
}
