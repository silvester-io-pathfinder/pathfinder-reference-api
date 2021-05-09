using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Ammunition : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int Price { get; set; }

        public int BatchAmount { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid WeaponGroupId { get; set; }
        public WeaponGroup WeaponGroup { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
    }
}
