using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class FoldingLadder : Template
    {
        public static readonly Guid ID = Guid.Parse("5cf814cc-6c15-4d9c-b3b6-c9fc524ba849");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Folding Ladder",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a819af9b-702f-4616-ba55-8b78ac1ce269"), "This multi-hinged, 10-foot ladder is useful for climbing upward or across dangerous pits. You can fold or unfold the ladder with two total Interact actions, which don't need to consecutive.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2375c0da-41ec-4d20-a26d-f77718ca4696"),
                Name = "Folding Ladder",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 300,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("5839be07-18b4-4b04-9f9d-975a2a137210"),
                Name = "Folding Ladder (Unfolded)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 300,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("344d5eb4-1d27-4c7c-9339-608aac86a165"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
