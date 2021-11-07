using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Ancestry : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int BaseSpeed { get; set; }
        
        public int BaseHealth { get; set; }

        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid EffectId { get; set; }
        public BooleanEffect Effect { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Trait> AncestryTraits { get; set; } = new List<Trait>();

        public ICollection<Heritage> Heritages { get; set; } = new List<Heritage>();

        public ICollection<AncestrySize> Sizes { get; set; } = new List<AncestrySize>();

        public ICollection<TextBlock> Description { get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> YouMight { get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> OthersProbably{ get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> PhysicalDescription{ get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> Society{ get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> AlignmentAndReligion{ get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> Adventurers { get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> Names { get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> OtherInformation { get; set; } = new List<TextBlock>();
        public ICollection<TextBlock> AdditionalMechanics { get; set; } = new List<TextBlock>();
        public string SampleNames { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
