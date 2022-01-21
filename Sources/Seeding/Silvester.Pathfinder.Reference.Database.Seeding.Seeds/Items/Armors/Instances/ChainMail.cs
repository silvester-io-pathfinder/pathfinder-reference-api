using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Armors.Instances
{
    public class ChainMail : Template
    {
        public static readonly Guid ID = Guid.Parse("6c357ddd-162b-4fc0-b2a1-23ec6f1bbef4");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Chain Mail",
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Chain.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8513e4e9-1ea1-4da2-ad65-74830ab74d2e"), "A suit of chain mail consists of several pieces of armor composed of small metal rings linked together in a protective mesh. It typically includes a chain shirt, leggings, a pair of arms, and a coif, collectively protecting most of the body.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("59133979-dba8-4dda-a1b2-6fccb73f2f4a"),
                Name = "Chain Mail",
                ArmorClassBonus = 4,
                Level = 0,
                Price = 600,
                DexterityCap = 1,
                RequiredStrength = 16,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e89967ad-3b07-4dd0-a973-d1dd8981030f"), Traits.Instances.Flexible.ID);
            builder.Add(Guid.Parse("eda55e39-0061-41ba-a321-361e0e0a2a55"), Traits.Instances.Noisy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cafddd9f-fffa-447f-af6b-759154d33281"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
