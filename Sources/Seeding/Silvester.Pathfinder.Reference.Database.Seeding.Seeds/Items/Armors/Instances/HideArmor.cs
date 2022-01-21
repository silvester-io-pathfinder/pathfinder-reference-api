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
    public class HideArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("36116598-e497-42fa-a206-f7971f09acc3");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Hide Armor",
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Leather.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("ee0c4c90-254a-4a19-9443-664d45d21730"), "A mix of furs, sturdy hide, and sometimes molded boiled leather, this armor provides protection due to its layers of leather, though its bulkiness slows the wearer down and decreases mobility.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("05a68db6-53f6-46cd-b7e5-21e65095d467"),
                Name = "Hide Armor",
                Level = 0,
                ArmorClassBonus = 3,
                Price = 200,
                DexterityCap = 2,
                RequiredStrength = 14,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce0ba8f1-670f-41eb-9a0b-6a398f2c9db0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
