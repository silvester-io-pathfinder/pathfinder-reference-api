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
    public class Piton : Template
    {
        public static readonly Guid ID = Guid.Parse("1a6ef531-3bb2-45ea-8946-b6234ff93796");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Piton",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f5aac716-bbf7-4b8d-b00c-98c0fc2ad901"), "These small spikes can be used as anchors to make climbing easier. To affix a piton, you must hold it in one hand and use a hammer to drive it in with your other hand. You can attach a rope to the hammered piton so that you don't fall all the way to the ground on a critical failure while Climbing.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b4ae8d2b-069f-4130-9053-3a136b6ac913"),
                Name = "Piton",
                Hands = "1",
                Level = 0,
                Price = 1,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0269601-b805-4072-bf5e-47dccbc21d78"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
