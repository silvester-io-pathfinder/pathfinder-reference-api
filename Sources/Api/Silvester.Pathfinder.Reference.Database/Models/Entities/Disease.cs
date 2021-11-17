using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Disease : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public int? DifficultyCheck { get; set; }

        public bool Spoilers { get; set; }

        public string Onset { get; set; } = default!;

        public Guid? SourcePageId { get; set; }
        public SourcePage? SourcePage { get; set; } = default!;

        public Guid SavingThrowStatId { get; set; }
        public SavingThrowStat SavingThrowStat { get; set; } = default!;

        public ICollection<Trait> Traits { get; set; } = new List<Trait>();
        public ICollection<DiseaseStage> Stages { get; set; } = new List<DiseaseStage>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class DiseaseSearchConfigurator : SearchableEntityConfigurator<Disease>
    {
        public override Expression<Func<Disease, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Onset };
        }
    }
}
