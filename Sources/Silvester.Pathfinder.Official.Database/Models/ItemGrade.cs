using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class ItemGrade : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<PreciousMaterialArmorVariant> ArmorVariants { get; set; } = new List<PreciousMaterialArmorVariant>();
    }
}
 