using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ClassFeature : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;
        public int Level { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public ICollection<TextBlock> Details = new List<TextBlock>();
        public ICollection<Class> Classes { get; set; } = new List<Class>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
