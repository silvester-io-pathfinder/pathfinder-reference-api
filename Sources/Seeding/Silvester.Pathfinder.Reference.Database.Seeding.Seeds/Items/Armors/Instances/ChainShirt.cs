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
    public class ChainShirt : Template
    {
        public static readonly Guid ID = Guid.Parse("9d419b32-9b59-4a20-9909-8485ae52f637");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Chain Shirt",
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Chain.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c85e39dd-a871-4c16-8448-790b3d7c822c"), "Sometimes called a hauberk, this is a long shirt constructed of the same metal rings as chainmail. However, it is much lighter than chainmail and protects only the torso, upper arms, and upper legs of its wearer.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("68f73138-e2b1-4b92-a858-6bb4b51c4c96"),
                Name = "Chain Shirt",
                ArmorClassBonus = 2,
                Level = 0,
                Price = 500,
                DexterityCap = 3,
                RequiredStrength = 12,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dd50bc20-85c1-49e6-af00-15413ab37fe1"), Traits.Instances.Flexible.ID);
            builder.Add(Guid.Parse("4c525f1f-1fd0-4834-9381-7d39d4bbd048"), Traits.Instances.Noisy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8494e18c-c37a-43ac-bf31-773ffa0195db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
