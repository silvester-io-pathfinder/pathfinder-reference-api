using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public interface IRollableEffect
    {
        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; }

        public string? Failure { get; set; }

        public string? CriticalFailure { get; set; }
    }

    public class RollableEffect : BaseEntity, IRollableEffect, ISearchableEntity
    {
        public Guid OwnerId { get; set; }
       
        public string? Name { get; set; }

        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; } 

        public string? Failure { get; set; } 

        public string? CriticalFailure { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class RollableEffectConfigurator : EntityConfigurator<RollableEffect>
	{
		public RollableEffectConfigurator()
		{
			ConfigureEntitySearch<RollableEffect>(e => new {e.Name, e.CriticalFailure, e.CriticalSuccess, e.Failure, e.Success});
		}
	}
}
