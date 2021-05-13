using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class LeatherArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("ee976251-119d-4b17-b47b-eea1fafb1fdf");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Leather Armor",
                ArmorClassBonus = 1,
                Price = 200,
                DexterityCap = 4,
                Strength= 10,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Leather.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f5334a06-4882-4033-8af1-043303b472d9"), Type = TextBlockType.Text, Text = "A mix of flexible and molded boiled leather, a suit of this type of armor provides some protection with maximum flexibility." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed63f55c-6a38-4b7f-b904-f07ed0c0f397"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
