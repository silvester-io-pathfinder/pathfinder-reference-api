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
    public class CartographersKit : Template
    {
        public static readonly Guid ID = Guid.Parse("9eaa4740-ca64-457f-b20e-94cbada90b59");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Cartographer's Kit",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ed20f43a-e3cf-4c2b-a5c0-47993f534e0f"), "Players can gain access to faction-specific gear by taking the corresponding Faction Gear Access Game Reward, available when they reach 20 reputation with the respective faction.");;
            builder.Text(Guid.Parse("7630b480-2289-4c24-ae0f-ffcb8bb3d30e"), "This kit includes a writing set, a compass, a standard astrolabe, a ruler, and a survey map.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("17dd9a47-bb5b-4b14-859c-149f22e3da29"),
                Name = "Cartographer's Kit",
                Level = 3,
                Price = 4200,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7028a268-35b0-47e5-92a2-1f1353e66e56"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 34
            };
        }
    }
}
