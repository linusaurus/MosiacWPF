using System.Collections.ObjectModel;
using Database.Models;

namespace Mosiac.Services
{
    public interface IAssetService
    {
        Asset Find(int assetID);
        ObservableCollection<Asset> GetAll();
        void Save(Asset asset);
    }
}