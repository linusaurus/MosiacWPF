using Database.Models;
using Mosiac.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosiac.ViewModels
{
    /// <summary>
    /// The ViewModel for the LoadOnDemand demo.  This simply
    /// exposes a read-only collection of regions.
    /// </summary>
    public class PartCategoryViewModel: TreeViewItemViewModel
    {
        readonly PartCategory _partCategory;
        private readonly IPartTypeLookup _partTypeLookup;

        public PartCategoryViewModel(PartCategory partCategory, IPartTypeLookup partTypeLookup )
           : base(null, true)
        {
            _partCategory = partCategory;
            _partTypeLookup = partTypeLookup;
        }

        public string CategoryName
        {
            get { return _partCategory.CategoryName; }
        }

        //protected async override void LoadChildren()
        //{
        //    //foreach (LookupItem partType in await _partTypeLookup.GetPartTypeLookupAsync(_partCategory.PartCategoryID ))
        //    //   base.Children.Add(new PartCategoryViewModel(state, this));
        //}
    }
}
