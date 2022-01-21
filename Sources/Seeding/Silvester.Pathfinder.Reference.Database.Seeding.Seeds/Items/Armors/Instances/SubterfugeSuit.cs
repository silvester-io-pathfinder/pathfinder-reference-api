using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Armors.Instances
{
    public class SubterfugeSuit : Template
    {
        public static readonly Guid ID = Guid.Parse("c205fe7b-2c52-48e3-8098-0fe3e62c501d");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Subterfuge Suit",
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
            }; 
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("2497f9b5-43b7-4523-99f9-e9d41ba1c505"), "A cutting-edge suit of medium armor with a variety of attached gizmos and devices.");;
            builder.Text(Guid.Parse("9a07aeba-5089-4b54-987f-f1edc37317ae"), "Your innovation armor can have fundamental and property runes added to it in the same way as ordinary armor. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in medium armor.");;
        }

        protected override IEnumerable<ArmorVariant> GetArmorVariants()
        {
            yield return new ArmorVariant
            {
                Id = Guid.Parse("352db8c2-f00a-4f13-a3c8-f53bccf956fc"),
                Name = "Subterfuge Suit",
                ArmorClassBonus = 1,
                Level = 0,
                DexterityCap = 4,
                RequiredStrength = 10,
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
                Id = Guid.Parse("f2f125ff-0fa1-4dd3-815a-d4318e34ec2b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 16
            };
        }
    }
}
