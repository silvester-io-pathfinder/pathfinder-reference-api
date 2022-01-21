using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Blocks : Template
    {
        public static readonly Guid ID = Guid.Parse("5d491b41-81cc-422a-a376-769884b0aba8");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Blocks",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fb22ea93-1fb7-4ae1-8829-bfe67ed77aca"), "These wooden blocks can be stacked to build flimsy structures. A standard set comes in a small sack with 12 blocks.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("0e10fcae-11c6-4ea5-b230-4494408bfd07"),
                Name = "Blocks",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5330316-5fa3-4775-8be4-615fad3bc48d"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58
            };
        }
    }
}
