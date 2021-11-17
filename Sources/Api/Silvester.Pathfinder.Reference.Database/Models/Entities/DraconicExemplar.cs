using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DraconicExemplar : BaseEntity, ISearchableEntity
    {
        public string Dragon { get; set; } = default!;

        public Guid EffectAreaId { get; set; }
        public EffectArea EffectArea { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DraconicExemplarSearchConfigurator : SearchableEntityConfigurator<DraconicExemplar>
    {
        public override Expression<Func<DraconicExemplar, object?>> GetSearchProperties()
        {
            return (e) => new { e.Dragon };
        }
    }
}
