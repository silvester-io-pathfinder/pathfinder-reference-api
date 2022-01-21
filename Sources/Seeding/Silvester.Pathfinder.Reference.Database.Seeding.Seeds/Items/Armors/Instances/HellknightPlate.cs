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
    public class HellknightPlate : Template
    {
        public static readonly Guid ID = Guid.Parse("abee6439-3461-45f5-b234-8e155921fc95");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Hellknight Plate",
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6c2f2ed3-13f6-4efe-be8c-70b921cd99e6"), "A character who is a member of the Hellknights has access to this uncommon armor.");;
            builder.Text(Guid.Parse("a86ab0c4-63d1-4ec2-891b-f308291731a5"), "Few armors in the Inner Sea region are as memorable as the iconic Hellknight plate. While each order has its own flourishes, Hellknight plate is instantly recognizable to any who know of the Hellknights. Hellknights go to extreme measures to punish non-Hellknights who get their hands on Hellknight plate, and the reward is not usually worth the risk, since for non-Hellknights, the armor is functionally similar to full plate.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("f3e4ae60-68d7-4fce-8fa7-f2a45305a20c"),
                Name = "Hellknight Plate",
                Level = 2,
                ArmorClassBonus = 6,
                Price = 3500,
                DexterityCap = 0,
                RequiredStrength = 18,
                CheckPenalty = 3,
                SpeedPenalty = 10,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2816622e-7182-47c7-b605-a89240b853e9"), Traits.Instances.Bulwark.ID);
            builder.Add(Guid.Parse("93b67aef-30dc-48fe-8e80-febcc49ebfe0"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4923a3b1-b93c-4cbb-b4ae-5b420f03c641"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 80
            };
        }
    }
}
