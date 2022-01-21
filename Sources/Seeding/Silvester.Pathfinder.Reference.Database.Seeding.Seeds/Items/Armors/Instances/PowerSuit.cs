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
    public class PowerSuit : Template
    {
        public static readonly Guid ID = Guid.Parse("b0065f7f-9afe-4988-9d27-e3eb84942a4b");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Power Suit",
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2cc51593-8546-4920-bc2e-ee2b8614ea13"), "A cutting-edge suit of medium armor with a variety of attached gizmos and devices.");;
            builder.Text(Guid.Parse("c2c8b152-a527-465b-a7ec-2aa2118ed543"), "Your innovation armor can have fundamental and property runes added to it in the same way as ordinary armor. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in medium armor.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("dca8016a-66b7-4af3-ba13-b4338c7f87eb"),
                Name = "Power Suit",
                ArmorClassBonus = 4,
                Level = 0,
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
                Id = Guid.Parse("303cd6fe-8a8f-49c1-99be-e5c696dcc0d6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
