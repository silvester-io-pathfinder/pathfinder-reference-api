using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Shield : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Price { get; set; }

        public int ArmorClassBonus { get; set; }

        public int SpeedPenalty { get; set; }

        public int Hardness { get; set; }

        public int HitPoints { get; set; }

        public int BrokenThreshold { get; set; }

        public Guid BulkId { get; set; }
        public Bulk Bulk { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ShieldSearchConfigurator : SearchableEntityConfigurator<Shield>
    {
        public override Expression<Func<Shield, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
