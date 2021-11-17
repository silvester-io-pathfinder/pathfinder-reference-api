using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Sense : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();
        
        public ICollection<Eidolon> Eidolons { get; set; } = new List<Eidolon>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class SenseConfigurator : SearchableEntityConfigurator<Sense>
    {
        public override Expression<Func<Sense, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
