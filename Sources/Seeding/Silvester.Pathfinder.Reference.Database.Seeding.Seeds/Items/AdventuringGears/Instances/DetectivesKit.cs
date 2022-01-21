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
    public class DetectivesKit : Template
    {
        public static readonly Guid ID = Guid.Parse("e4eeffb1-68b5-4846-be37-62118863014e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Detective's Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ccb1bc2d-5cf3-495b-b677-19dcfc8b54d8"), "This leather satchel contains empty vials, a pair of tweezers, a supply of small linen cloths, a set of brass calipers and a knotted string for measuring distances, several pieces of chalk, a pen, and a blank notebook for keeping notes. Every component of a detective's kit is of exceeding quality, and thus a detective's kit adds a +1 item bonus to checks to investigate a crime scene, a clue, or similar details.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("f572ea13-58b1-4f6c-8a38-d2bd39eb39fc"),
                Name = "Detective's Kit",
                Level = 3,
                Hands = "2",
                Price = 2500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c60b4087-35ad-400b-b704-825fce18f256"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
