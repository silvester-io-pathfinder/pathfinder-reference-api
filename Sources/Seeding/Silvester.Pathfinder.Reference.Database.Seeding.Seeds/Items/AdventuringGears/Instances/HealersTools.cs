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
    public class HealersTools : Template
    {
        public static readonly Guid ID = Guid.Parse("b65586b9-cfee-42b5-ab60-881766c60c2e");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Healer's Tools",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("89f73e16-1bc9-4b3e-8d80-bc2879ac23ac"), "This kit of bandages, herbs, and suturing tools is necessary for Medicine checks to Administer First Aid, Treat Disease, Treat Poison, or Treat Wounds. If you wear your healer's tools, you can draw and replace them as part of the action that uses them.");;
        }
        
        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2e27d510-7259-40cc-bc8e-688084398107"),
                Name = "Healer's Tools",
                Hands = "2",
                Level = 0,
                Price = 500,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("297cce48-9ff9-42ab-b9a3-94a490f029bf"),
                Name = "Healer's Tools (Expanded)",
                Hands = "2",
                Level = 3,
                Price = 5000,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4ae79cac-e216-4660-8bcc-f0734ab057b0"), "Expanded healer's tools provide a +1 item bonus to such checks.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ffa6270-930f-4d44-b4e0-63bc0383d422"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
