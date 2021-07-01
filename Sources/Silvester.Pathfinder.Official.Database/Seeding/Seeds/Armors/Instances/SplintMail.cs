using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class SplintMail : Template
    {
        public static readonly Guid ID = Guid.Parse("e95aa60c-9410-40f5-9c26-7d33be653193");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Level = 1,
                Name = "Splint Mail",
                ArmorClassBonus = 5,
                Price = 1300,
                DexterityCap = 1,
                Strength = 16,
                CheckPenalty = 3,
                SpeedPenalty = 10,
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
                BulkId = Bulks.Instances.ThreeBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8d94c1d8-41d5-416d-b928-40bc00950de3"), Type = TextBlockType.Text, Text = "This type of armor is chain mail reinforced with flexible, interlocking metal plates, typically located on the wearer’s torso, upper arms, and legs. A suit of this armor comes with an undercoat of padded armor and a pair of gauntlets." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30b58156-4b70-4443-b4e3-af6fe97baf0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
