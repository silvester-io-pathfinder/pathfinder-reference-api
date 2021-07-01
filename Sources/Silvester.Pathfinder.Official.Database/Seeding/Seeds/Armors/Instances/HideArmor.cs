using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class HideArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("36116598-e497-42fa-a206-f7971f09acc3");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Hide Armor",
                ArmorClassBonus = 3,
                Price = 200,
                DexterityCap = 2,
                Strength = 14,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Leather.ID,
                BulkId = Bulks.Instances.TwoBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ee0c4c90-254a-4a19-9443-664d45d21730"), Type = TextBlockType.Text, Text = "A mix of furs, sturdy hide, and sometimes molded boiled leather, this armor provides protection due to its layers of leather, though its bulkiness slows the wearer down and decreases mobility." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce0ba8f1-670f-41eb-9a0b-6a398f2c9db0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
