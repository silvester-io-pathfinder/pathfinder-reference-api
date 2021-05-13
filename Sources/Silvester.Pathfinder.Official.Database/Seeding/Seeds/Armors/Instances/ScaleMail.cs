using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class ScaleMail : Template
    {
        public static readonly Guid ID = Guid.Parse("e238440f-34b9-4583-b0df-467bf3a19319");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Scale Mail",
                ArmorClassBonus = 3,
                Price = 400,
                DexterityCap = 2,
                Strength = 14,
                CheckPenalty = 2,
                SpeedPenalty = 5,
                ArmorCategoryId = ArmorCategories.Instances.MediumArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Composite.ID,
                BulkId = Bulks.Instances.TwoBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("247c9d0a-b5a0-41a7-a93d-5d31230b68fc"), Type = TextBlockType.Text, Text = "Scale mail consists of many metal scales sewn onto a reinforced leather backing, often in the form of a long shirt that protects the torso, arms, and legs." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0efead34-422d-4891-ac8d-e471b868aaed"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
