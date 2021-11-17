using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Plane : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid CategoryId { get; set; }
        public PlaneCategory Category { get; set; } = default!;

        public Guid AlignmentId { get; set; }
        public Alignment Alignment { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PlaneSearchConfigurator : SearchableEntityConfigurator<Plane>
    {
        public override Expression<Func<Plane, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
