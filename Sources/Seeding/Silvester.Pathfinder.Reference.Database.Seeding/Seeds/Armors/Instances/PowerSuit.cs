using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Armors.Instances
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
                ArmorClassBonus = 4,
                DexterityCap = 1,
                Strength = 16,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
                BulkId = Bulks.Instances.TwoBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2cc51593-8546-4920-bc2e-ee2b8614ea13"), Type = TextBlockType.Text, Text = "A cutting-edge suit of medium armor with a variety of attached gizmos and devices." };
            yield return new TextBlock { Id = Guid.Parse("c2c8b152-a527-465b-a7ec-2aa2118ed543"), Type = TextBlockType.Text, Text = "Your innovation armor can have fundamental and property runes added to it in the same way as ordinary armor. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in medium armor." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
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
