using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Vigilante : Template
    {
        public static readonly Guid ID = Guid.Parse("115a8b87-c636-4528-91a0-d9d5ddfeebb4");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Vigilante",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eb7bab2d-58f7-4bb1-9209-6e3ad3d5cb85"), Type = TextBlockType.Text, Text = "Using actions and abilities with the vigilante trait while in your social identity risks exposing you as a vigilante." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15136271-9d87-46f4-b91c-0d9eaf221b10"),
                SourceId = AdvancedPlayersGuide.ID,
                Page = 271
            };
        }
    }
}
