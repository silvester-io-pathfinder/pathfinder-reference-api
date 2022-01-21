using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Artifacts
{
    public abstract class Template : Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Template<Artifact, ArtifactVariant>
    {
        protected override sealed Artifact GetItem()
        {
            return GetArtifact();
        }

        protected override sealed IEnumerable<ArtifactVariant> GetVariants()
        {
            return GetArtifactVariants();
        }

        protected abstract IEnumerable<ArtifactVariant> GetArtifactVariants();
        protected abstract Artifact GetArtifact();
    }
}
