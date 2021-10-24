using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ItemGrade : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<PreciousMaterialArmorVariant> ArmorVariants { get; set; } = new List<PreciousMaterialArmorVariant>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
 