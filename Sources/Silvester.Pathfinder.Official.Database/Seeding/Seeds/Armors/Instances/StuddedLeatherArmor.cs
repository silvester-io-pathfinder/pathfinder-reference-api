using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Armors.Instances
{
    public class StuddedLeatherArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("653970e9-fa6d-492a-a58e-36d505a38657");

        protected override Armor GetArmor()
        {
            return new Armor
            {
                Id = ID,
                Name = "Studded Leather Armor",
                ArmorClassBonus = 2,
                Price = 300,
                DexterityCap = 3,
                Strength = 12,
                CheckPenalty = 1,
                SpeedPenalty = 0,
                ArmorCategoryId = ArmorCategories.Instances.LightArmor.ID,
                ArmorGroupId = ArmorGroups.Instances.Leather.ID,
                BulkId = Bulks.Instances.OneBulk.ID
            }; 
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7f9f4ce5-04a8-4c1f-84e4-9dac5e1fb616"), Type = TextBlockType.Text, Text = "This leather armor is reinforced with metal studs and sometimes small metal plates, providing most of the flexibility of leather armor with more robust protection." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f6e3d5f-97c1-474c-9ad6-dc71d6bfc8f3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 275
            };
        }
    }
}
