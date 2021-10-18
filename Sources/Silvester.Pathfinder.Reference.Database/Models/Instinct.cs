using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class Instinct : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public string SpecializationAbility { get; set; } = default!;

        public string Anathema { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;
        
        public Guid ClassId { get; set; }
        public Class Class { get; set; } = default!;

        public Guid? TableId { get; set; }
        public Table? Table { get; set; }

        public Guid InstinctAbilityEffectId { get; set; }
        public InstinctEffectBinding InstinctAbilityEffect { get; set; } = default!;

        public ICollection<InstinctEffectBinding> RagingEffects { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
