using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites
{
    public class BooleanPrerequisite : BasePrerequisite
    {
        public string? Addendum { get; set; }

        public BooleanOperator Operator { get; set; }

        public ICollection<BooleanPrerequisiteBinding> Entries { get; set; } = new List<BooleanPrerequisiteBinding>();
    }

    public class BooleanPrerequisiteBinding : BaseEntity
    {
        public Guid BooleanPrerequisiteId { get; set; }
        public BooleanPrerequisite BooleanPrerequisite { get; set; } = default!;

        public Guid PrerequisiteId { get; set; }
        public BasePrerequisite Prerequisite { get; set; } = default!;
    }
}
