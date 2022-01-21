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
    public class HalfPlate : Template
    {
        public static readonly Guid ID = Guid.Parse("b19fb537-a420-4506-a444-fc9f58db5c11");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Half Plate",
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fac46981-86cf-43fb-8baa-f2eb63dd18fb"), "Half plate consists of most of the upper body plates used in full plate, with lighter or sparser steel plate protection for the arms and legs. This provides some of the protection of full plate with greater flexibility and speed. A suit of this armor comes with an undercoat of padded armor and a pair of gauntlets.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("693a2c8f-5460-430a-ab5e-916d1dd538af"),
                Name = "Half Plate",
                ArmorClassBonus = 5,
                Level = 1,
                Price = 1800,
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
                Id = Guid.Parse("bf73b11a-17bd-4abb-a6c6-70fdec059cdc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
