using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Armors.Instances
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
                ArmorClassBonus = 1,
                DexterityCap = 4,
                Strength = 10,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2497f9b5-43b7-4523-99f9-e9d41ba1c505"), Type = TextBlockType.Text, Text = "A cutting-edge suit of medium armor with a variety of attached gizmos and devices." };
            yield return new TextBlock { Id = Guid.Parse("9a07aeba-5089-4b54-987f-f1edc37317ae"), Type = TextBlockType.Text, Text = "Your innovation armor can have fundamental and property runes added to it in the same way as ordinary armor. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in medium armor." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
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
