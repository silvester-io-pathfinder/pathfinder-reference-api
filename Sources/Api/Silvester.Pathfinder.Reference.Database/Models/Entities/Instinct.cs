using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Instinct : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string SpecializationAbility { get; set; } = default!;

        public string Anathema { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
        
        public Guid? RagingEffectId { get; set; }
        public BooleanEffect? RagingEffect { get; set; }

        public Guid? InstinctAbilityEffectId { get; set; }
        public BooleanEffect? InstinctAbilityEffect { get; set; }

        public Guid? TableId { get; set; }
        public Table? Table { get; set; }
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class InstinctSearchConfigurator : SearchableEntityConfigurator<Instinct>
    {
        public override Expression<Func<Instinct, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
