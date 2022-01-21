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
    public class PaddedArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("cb7b819d-3ddc-4819-bdb1-a0bafa47ead0");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Padded Armor",
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Cloth.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d8d5ca54-b095-4db0-a98b-a7eb2be10d34"), "This armor is simply a layer of heavy, quilted cloth, but it is sometimes used because it's so inexpensive. Padded armor is easier to damage and destroy than other types of armor. Heavy armor comes with a padded armor undercoat included in its Price, though it loses the comfort trait when worn under heavy armor. You can wear just that padded armor undercoat to sleep in, if your heavy armor is destroyed, or when otherwise not wearing the full heavy armor. This allows you to keep the armor invested and benefit from the power of any runes on the associated heavy armor, but no one else can wear your heavy armor without the padded undercoat.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("f11c8dbb-2c15-4520-8c32-b2b96bbcd5b0"),
                Name = "Padded Armor",
                ArmorClassBonus = 1,
                Level = 0,
                Price = 20,
                DexterityCap = 3,
                RequiredStrength = 10,
                CheckPenalty = 0,
                SpeedPenalty = 0,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("d504295f-479f-4ee1-9b70-6c9200ab5d30"), Traits.Instances.Comfort.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b419b75-918b-4d39-a7b3-baf2c19c68d8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
