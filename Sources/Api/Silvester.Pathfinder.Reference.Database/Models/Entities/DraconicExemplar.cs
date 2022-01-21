using NpgsqlTypes;
using System;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class DraconicExemplar : BaseEntity, ISearchableEntity
    {
        public string Dragon { get; set; } = default!;

        public Guid EffectShapeId { get; set; }
        public EffectShape EffectShape { get; set; } = default!;

        public Guid DamageTypeId { get; set; }
        public DamageType DamageType { get; set; } = default!;

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DraconicExemplarConfigurator : EntityConfigurator<DraconicExemplar>
	{
		public DraconicExemplarConfigurator()
		{
			ConfigureEntitySearch<DraconicExemplar>(e => new {e.Dragon});
		}
	}
}
