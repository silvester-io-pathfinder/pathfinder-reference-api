using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Heritage : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;


        public Guid RarityId { get; set; }
        public Rarity Rarity { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public ICollection<Ancestry> Ancestries { get; set; } = new List<Ancestry>();
        public ICollection<TextBlock> Details{ get; set; } = new List<TextBlock>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
