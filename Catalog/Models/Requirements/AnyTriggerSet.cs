using System.Collections.Generic;
using Catalog.Models.Base;
using Catalog.Models.Questions;

namespace Catalog.Models.Requirements
{
    public class AnyTriggerSet : ModelBase
    {
        public AnyTriggerSet()
        {
            AnyTriggers = new List<Trigger>();
        }

        public AnyTriggerSet(List<Trigger> triggers)
        {
            AnyTriggers = triggers;
        }
        public List<Trigger> AnyTriggers { get; set; }
    }
}