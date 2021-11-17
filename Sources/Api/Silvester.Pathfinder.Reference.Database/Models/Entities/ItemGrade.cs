using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ItemGrade : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Order { get; set; }

        public ICollection<PreciousMaterialArmorVariant> ArmorVariants { get; set; } = new List<PreciousMaterialArmorVariant>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ItemGradeSearchConfigurator : SearchableEntityConfigurator<ItemGrade>
    {
        public override Expression<Func<ItemGrade, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
 