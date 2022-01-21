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
    public class HarrowMat : Template
    {
        public static readonly Guid ID = Guid.Parse("37411366-33fe-469f-93bb-02f2fed76911");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Harrow Mat",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0a91cfd8-1dbd-44e4-87a5-06ad81444ef7"), "This leather mat bears intricate designs and symbols embossed into them to enhance the mystique of a harrow reading. The mat provides a +1 item bonus to Deception, Diplomacy, and relevant Lore checks (such as Fortune-Telling Lore or Harrow Lore) to convince a creature that a harrow reading was accurate.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("bb71ed17-0e1b-49f0-93ce-3a7adc78ab2d"),
                Name = "Harrow Mat",
                Hands = "2",
                Level = 0,
                Price = 800,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2575f21e-b56a-4d81-b428-0994a973632c"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
