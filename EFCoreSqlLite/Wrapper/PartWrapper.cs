using Database.Models;
using Mosiac.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosiac.Wrapper
{
    public class PartWrapper :  ModelWrapper<Part>
    {
        public PartWrapper(Part model): base(model)
        {

        }

        public int Id { get { return Model.PartID; } }

        public string ItemDescription
        {
            get { return GetValue<string>();}
            set { SetValue(value); }
        }
        public string ItemName
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string PartNum
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int ManuID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public bool ObsoluteFlag
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public int PartTypeID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public decimal Cost
        {
            get { return GetValue<decimal>(); }
            set { SetValue(value); }
        }

        public int UID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string  Location
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int SupplierID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

        public string SupplierDescription
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public bool UseSupplierNameFlag
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }

        public string ManuPartNum
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string SKU
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public bool CARBtrack
        {
            get { return GetValue<bool>(); }
            set { SetValue(value); }
        }


    }
}
