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
    public class ScaleMail : Template
    {
        public static readonly Guid ID = Guid.Parse("e238440f-34b9-4583-b0df-467bf3a19319");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Scale Mail",
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("247c9d0a-b5a0-41a7-a93d-5d31230b68fc"), "Scale mail consists of many metal scales sewn onto a reinforced leather backing, often in the form of a long shirt that protects the torso, arms, and legs.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("11068825-3973-4483-bbf9-9446d32333bd"),
                Name = "Scale Mail",
                ArmorClassBonus = 3,
                Level = 0,
                Price = 400,
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
                Id = Guid.Parse("0efead34-422d-4891-ac8d-e471b868aaed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
