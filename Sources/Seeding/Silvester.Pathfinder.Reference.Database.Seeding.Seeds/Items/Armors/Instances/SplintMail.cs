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
    public class SplintMail : Template
    {
        public static readonly Guid ID = Guid.Parse("e95aa60c-9410-40f5-9c26-7d33be653193");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Splint Mail",
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8d94c1d8-41d5-416d-b928-40bc00950de3"), "This type of armor is chain mail reinforced with flexible, interlocking metal plates, typically located on the wearer's torso, upper arms, and legs. A suit of this armor comes with an undercoat of padded armor and a pair of gauntlets.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("0a2a6051-8df4-4ed9-a560-08d38c4228fc"),
                Name = "Splint Mail",
                Level = 1,
                ArmorClassBonus = 5,
                Price = 1300,
                DexterityCap = 1,
                RequiredStrength = 16,
                CheckPenalty = 3,
                SpeedPenalty = 10,
                BulkId = Bulks.Instances.ThreeBulk.ID,
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
                Id = Guid.Parse("30b58156-4b70-4443-b4e3-af6fe97baf0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
