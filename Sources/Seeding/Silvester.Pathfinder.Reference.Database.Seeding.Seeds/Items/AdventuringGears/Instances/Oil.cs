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
    public class Oil : Template
    {
        public static readonly Guid ID = Guid.Parse("cc4d4621-bf02-484a-93ad-9b14f6e93b0b");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Oil",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("a31be45d-e190-43d7-84a6-5a45416d25a5"), "You can use oil to fuel lanterns, but you can also set a pint of oil aflame and throw it. You must first spend an Interact action preparing the oil, then throw it with another action as a ranged attack. If you hit, it splatters on the creature or in a single 5-foot square you target. You must succeed at a DC 10 flat check for the oil to ignite successfully when it hits. If the oil ignites, the target takes 1d6 fire damage.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("1dd0a59f-5ef8-4178-ad79-2b452e26a5c8"),
                Name = "Oil",
                Hands = "2",
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
                Id = Guid.Parse("dcfdd5ba-a856-40a3-b30f-445aea929b24"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 291
            };
        }
    }
}
