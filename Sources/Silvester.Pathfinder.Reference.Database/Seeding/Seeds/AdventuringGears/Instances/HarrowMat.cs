using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AdventuringGears.Instances
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
                Hands = "2",
                Price = 800,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0a91cfd8-1dbd-44e4-87a5-06ad81444ef7"), Type = TextBlockType.Text, Text = "This leather mat bears intricate designs and symbols embossed into them to enhance the mystique of a harrow reading. The mat provides a +1 item bonus to Deception, Diplomacy, and relevant Lore checks (such as Fortune-Telling Lore or Harrow Lore) to convince a creature that a harrow reading was accurate." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2575f21e-b56a-4d81-b428-0994a973632c"),
                SourceId = Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
