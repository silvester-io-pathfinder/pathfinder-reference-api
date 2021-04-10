using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ConditionCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();
    }
}
