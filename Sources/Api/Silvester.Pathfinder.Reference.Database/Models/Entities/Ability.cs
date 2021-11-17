using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Ability : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string? Requirements { get; set; } = default!;
        public string? Trigger { get; set; } = default!;
        public string? Description { get; set; } = default!;

        public Guid ActionTypeId { get; set; }
        public ActionType ActionType { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? RollableEffectId { get; set; }
        public RollableEffect? RollableEffect { get; set; } 

        public ICollection<TextBlock> Effects { get; set; } = new List<TextBlock>();
        public ICollection<Trait> Traits { get; set; } = new List<Trait>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AbilitySearchConfigurator : SearchableEntityConfigurator<Ability>
    {
        public override Expression<Func<Ability, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
