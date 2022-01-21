using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Spyglass : Template
    {
        public static readonly Guid ID = Guid.Parse("6afd5c23-72ad-48e0-bb63-6dec160c3e73");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Spyglass",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("08f152c3-8c0e-4c63-a26b-67db03030021"), "A typical spyglass lets you see eight times farther than normal.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5a0e3842-7128-45c3-99a3-f04f99a6deea"),
                Name = "Spyglass",
                Hands = "2",
                Price = 2000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("e75078d5-0865-4a97-aa5c-043de31f462e"),
                Name = "Spyglass (Fine)",
                Hands = "2",
                Level = 4,
                Price = 8000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("448d1176-f41b-43ab-8ebe-0c67d1b75701"), "A fine spyglass adds a +1 item bonus to Perception checks to notice details at a distance.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b65a32ec-7241-46a9-ad3a-1e8bce4f75bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
