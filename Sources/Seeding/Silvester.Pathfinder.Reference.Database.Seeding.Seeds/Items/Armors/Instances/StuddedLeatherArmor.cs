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
    public class StuddedLeatherArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("653970e9-fa6d-492a-a58e-36d505a38657");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Studded Leather Armor",
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Leather.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("7f9f4ce5-04a8-4c1f-84e4-9dac5e1fb616"), "This leather armor is reinforced with metal studs and sometimes small metal plates, providing most of the flexibility of leather armor with more robust protection.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("41b68919-4eeb-4c47-afed-04eddcaeae66"),
                Name = "Studded Leather Armor",
                ArmorClassBonus = 2,
                Level = 0,
                Price = 300,
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
            
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f6e3d5f-97c1-474c-9ad6-dc71d6bfc8f3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
