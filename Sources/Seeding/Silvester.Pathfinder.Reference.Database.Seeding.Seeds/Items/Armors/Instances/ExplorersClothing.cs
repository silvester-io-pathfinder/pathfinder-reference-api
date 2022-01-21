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
    public class ExplorersClothing : Template
    {
        public static readonly Guid ID = Guid.Parse("6fbffdfc-1443-4f6b-980b-a3d17412ac93");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Explorer's Clothing",
                ArmorCategoryId = ArmorCategories.Instances.Unarmored.ID,
                ArmorGroupId = ArmorGroups.Instances.Cloth.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("915c591a-6d4e-4a6c-9ad1-8ee619a7ffd8"), "Adventurers who don't wear armor travel in durable clothing. Though it's not armor and uses your unarmored defense proficiency, it still has a Dex Cap and can grant an item bonus to AC if etched with potency runes.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("a31ae113-b9e3-498e-a847-9ab8dc3f5cad"),
                Name = "Explorer's Clothing",
                ArmorClassBonus = 0,
                Level = 0,
                Price = 10,
                DexterityCap = 5,
                RequiredStrength = 0,
                CheckPenalty = 0,
                SpeedPenalty = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("37c02b02-51c7-411e-8105-b6a38026efde"), Traits.Instances.Comfort.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e4472c2-1fce-4c38-a4f0-fbca470146b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
