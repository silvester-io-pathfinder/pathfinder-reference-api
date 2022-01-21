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
    public class LeatherArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("ee976251-119d-4b17-b47b-eea1fafb1fdf");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Leather Armor",
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Leather.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f5334a06-4882-4033-8af1-043303b472d9"), "A mix of flexible and molded boiled leather, a suit of this type of armor provides some protection with maximum flexibility.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("d8556cbd-b160-4dda-9226-02a412fd30de"),
                Name = "Leather Armor",
                ArmorClassBonus = 1,
                Level = 0,
                Price = 200,
                DexterityCap = 4,
                RequiredStrength = 10,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                BulkId = Bulks.Instances.OneBulk.ID,
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
                Id = Guid.Parse("ed63f55c-6a38-4b7f-b904-f07ed0c0f397"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
