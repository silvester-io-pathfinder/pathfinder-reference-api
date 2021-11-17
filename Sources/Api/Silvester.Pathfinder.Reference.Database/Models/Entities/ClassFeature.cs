using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ClassFeature : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;
        public int Level { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ClassFeatureSearchConfigurator : SearchableEntityConfigurator<ClassFeature>
    {
        public override Expression<Func<ClassFeature, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
