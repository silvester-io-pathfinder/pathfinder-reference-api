using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class FullPlate : Template
    {
        public static readonly Guid ID = Guid.Parse("ee6f41ed-1e5b-4ef9-8f4d-a2720aa9e477");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Level = 2,
                Name = "Full Plate",
                ArmorClassBonus = 6,
                Price = 3000,
                DexterityCap = 0,
                Strength = 18,
                CheckPenalty = 3,
                SpeedPenalty = 10,
                ArmorCategoryId = ArmorCategories.Instances.HeavyArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Plate.ID,
                BulkId = Bulks.Instances.FourBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("87d33432-9b15-4be9-a08f-33059cc6b7d2"), Type = TextBlockType.Text, Text = "Plate mail consists of interlocking plates that encase nearly the entire body in a carapace of steel. It is costly and heavy, and the wearer often requires help to don it correctly, but it provides some of the best defense armor can supply. A suit of this armor comes with an undercoat of padded armor and a pair of gauntlets." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Bulwark.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77921583-9403-4b05-887c-affeaea861ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
