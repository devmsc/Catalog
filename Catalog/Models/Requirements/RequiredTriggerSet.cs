using System.Collections.Generic;
using Catalog.Models.Base;
using Catalog.Models.Questions;

namespace Catalog.Models.Requirements
{
    public class RequiredTriggerSet : ModelBase
    {
        public RequiredTriggerSet()
        {
            RequiredTriggers = new List<Trigger>();
        }

        public RequiredTriggerSet(List<Trigger> triggers)
        {
            RequiredTriggers = triggers;
        }
        public List<Trigger> RequiredTriggers { get; set; }
    }
}