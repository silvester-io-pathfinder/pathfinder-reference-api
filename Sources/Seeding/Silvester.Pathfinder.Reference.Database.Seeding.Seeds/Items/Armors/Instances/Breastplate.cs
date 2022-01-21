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
    public class Breastplate : Template
    {
        public static readonly Guid ID = Guid.Parse("e376e538-e4c3-49b8-bff2-239a76012ec9");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Breastplate",
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4332249c-d32b-4dfe-9025-2a1f4bbb6f88"), "Though referred to as a breastplate, this type of armor consists of several pieces of plate or half-plate armor that protect the torso, chest, neck, and sometimes the hips and lower legs. It strategically grants some of the protection of plate while allowing greater flexibility and speed.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("94ce773e-8115-4ce4-a215-5143a874132f"),
                Name = "Breastplate",
                ArmorClassBonus = 4,
                Level = 0,
                Price = 800,
                DexterityCap = 1,
                RequiredStrength = 16,
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
                Id = Guid.Parse("21de43a5-f03c-4532-b544-ce63ae29b89f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
