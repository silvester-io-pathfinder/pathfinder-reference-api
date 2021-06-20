using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AdventuringGears.Instances
{
    public class HealersTools : Template
    {
        public static readonly Guid ID = Guid.Parse("b65586b9-cfee-42b5-ab60-881766c60c2e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Healer's Tools",
                Hands = "2",
                Price = 500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<AdventuringGearVariant> GetVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("297cce48-9ff9-42ab-b9a3-94a490f029bf"),
                NameAddendum = "Expanded",
                DescriptionAddendum = "Expanded healer's tools provide a +1 item bonus to such checks.",
                ItemLevel = 3,
                Price = 5000,
                Hands = 2,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("89f73e16-1bc9-4b3e-8d80-bc2879ac23ac"), Type = TextBlockType.Text, Text = "This kit of bandages, herbs, and suturing tools is necessary for Medicine checks to Administer First Aid, Treat Disease, Treat Poison, or Treat Wounds. If you wear your healer's tools, you can draw and replace them as part of the action that uses them." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ffa6270-930f-4d44-b4e0-63bc0383d422"),
                SourceId = CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
