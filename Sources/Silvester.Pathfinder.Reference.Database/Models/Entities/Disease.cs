using NpgsqlTypes;
using System;
using System.Collections.Generic;

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
}
