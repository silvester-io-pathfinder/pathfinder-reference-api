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
    public class FullPlate : Template
    {
        public static readonly Guid ID = Guid.Parse("ee6f41ed-1e5b-4ef9-8f4d-a2720aa9e477");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Full Plate",
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("87d33432-9b15-4be9-a08f-33059cc6b7d2"), "Plate mail consists of interlocking plates that encase nearly the entire body in a carapace of steel. It is costly and heavy, and the wearer often requires help to don it correctly, but it provides some of the best defense armor can supply. A suit of this armor comes with an undercoat of padded armor and a pair of gauntlets.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("cfe1f47c-08b9-48a3-b3a1-fcab6f17cbbf"),
                Name = "Full Plate",
                Level = 2,
                ArmorClassBonus = 6,
                Price = 3000,
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
            builder.Add(Guid.Parse("3d9c77ab-8adb-4488-bf85-8b3fc6e61ce2"), Traits.Instances.Bulwark.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77921583-9403-4b05-887c-affeaea861ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
