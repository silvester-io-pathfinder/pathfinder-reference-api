using NpgsqlTypes;
using Silvester.Pathfinder.Official.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Official.Database.Utilities.Text
{
    public class TextBlock : BaseEntity, ISearchableEntity, IOwnedEntity
    {
        public Guid OwnerId { get; set; }

        public string Text { get; set; } = default!;

        public int Order { get; set; }

        public TextBlockType Type { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class TextBlockConfigurator : SearchableEntityConfigurator<TextBlock>
    {
        public override Expression<Func<TextBlock, object>> GetSearchProperties()
        {
            return e => new { e.Text };
        }
    }
}
