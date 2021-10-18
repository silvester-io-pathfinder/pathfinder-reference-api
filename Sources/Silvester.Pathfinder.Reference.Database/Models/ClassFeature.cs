using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models
{
    public class ClassFeature : BaseEntity, INamedEntity, ISearchableEntity
    {
        public string Name { get; set; } = default!;
        public int Level { get; set; }

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details = new List<TextBlock>();
        public ICollection<Class> Classes { get; set; } = new List<Class>();
        public ICollection<ClassFeatureEffectBinding> Effects { get; set; } = new List<ClassFeatureEffectBinding>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
