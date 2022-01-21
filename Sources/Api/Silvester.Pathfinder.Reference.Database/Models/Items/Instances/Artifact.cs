using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Artifact : BaseItem
    {

    }

    public class ArtifactVariant : BaseItemVariant, ISearchableEntity
    {
        public string? Usage { get; set; }
        public int? Hands { get; set; }
        public string? Destruction { get; set; } = default!;
        public int Level { get; set; }

        public Guid? AlignmentId { get; set; }
        public Alignment? Alignment { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ArtifactVariantConfigurator : EntityConfigurator<ArtifactVariant>
	{
		public ArtifactVariantConfigurator()
		{
			ConfigureEntitySearch<ArtifactVariant>(e => new {e.Name, e.Destruction, e.Usage});
		}
	}
}
