using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mosiac.Events
{
    public class AfterPartSavedEvent : PubSubEvent<AfterPartSavedEventArgs>
    {
    }

    public class AfterPartSavedEventArgs
    {
        public int Id { get; set; }
        public string DisplayMember { get; set; }
    }
}
