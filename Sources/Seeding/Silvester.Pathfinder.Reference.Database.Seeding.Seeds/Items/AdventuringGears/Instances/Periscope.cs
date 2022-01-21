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
    public class Periscope : Template
    {
        public static readonly Guid ID = Guid.Parse("a905c052-59af-4d59-8e6b-3dddbe09675a");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Periscope",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("13b0edc2-2f01-41b7-b409-812959ca0a25"), "This is a 2-foot-long tube with two angled mirrors, one at each end. When the mirrors are aligned correctly, you can look around obstacles while remaining behind cover. This doesn't provide a sufficient line of effect to target creatures around corners.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("fe83dbb7-6471-4765-af6a-d33fda4c7230"),
                Name = "Periscope",
                Hands = "2",
                Level = 2,
                Price = 2500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7441bb2d-ec5e-402c-becb-929d7463ca1e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 249
            };
        }
    }
}
