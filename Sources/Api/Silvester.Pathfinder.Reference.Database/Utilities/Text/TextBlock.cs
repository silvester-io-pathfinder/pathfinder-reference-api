using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Utilities.Text
{
    public class TextBlock : BaseEntity, ISearchableEntity, IOwnedEntity
    {
        public Guid OwnerId { get; set; }

        public string Text { get; set; } = default!;

        public int Order { get; set; }

        public TextBlockType Type { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class TextBlockConfigurator : EntityConfigurator<TextBlock>
	{
		public TextBlockConfigurator()
		{
			ConfigureOwnedSearch<TextBlock>(e => new {e.Text});
		}
	}
}
