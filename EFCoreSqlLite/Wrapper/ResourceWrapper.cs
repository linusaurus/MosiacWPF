using Database.Models;
using Mosiac.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosiac.Wrapper
{
    public class ResourceWrapper :  ModelWrapper<Document>
    {
        public ResourceWrapper(Document model): base(model)
        {

        }

        public int Id { get { return Model.DocID; } }

        public string Description
        {
            get { return GetValue<string>();}
            set { SetValue(value); }
        }
        public string DocumentPath
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public string DocumentView
        {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }

        public int PartID
        {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }

    
    }
}
