using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class ColdIronArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("fb952584-d9f7-405e-bab1-d518f3c63519");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Cold Iron Armor",
                MaterialId = PreciousMaterials.Instances.ColdIron.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5288c524-3508-48a0-86df-73addb0eb5b1"), Type = TextBlockType.Text, Text = "Cold iron armor sickens certain creatures that touch it. A creature with weakness to cold iron (such as most demons and fey) that critically fails an unarmed attack against a creature in cold iron armor becomes sickened 1. A creature with weakness to cold iron is sickened 1 as long as it wears cold iron armor." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("af3bf504-b5d3-4533-90da-bd08858e132e"),
                CraftRequirements = "The initial raw materials must include cold iron worth at least 70 sp + 7 sp per Bulk.",
                Price = 14000,
                AdditionalPricePerBulk = 1400,
                ItemLevel = 5,
                GradeId = ItemGrades.Instances.LowGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("e65f967e-3a5d-449e-93df-c99125a15c4e"),
                CraftRequirements = "The initial raw materials must include at least 150 gp of cold iron + 15 gp per Bulk.",
                Price = 120000,
                AdditionalPricePerBulk = 12000,
                ItemLevel = 11,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("d73585c8-1e21-437d-9df9-bde28de2b3b3"),
                CraftRequirements = "The initial raw materials must include cold iron worth at least 10,000 gp + 1,000 gp per Bulk.",
                Price = 2000000,
                AdditionalPricePerBulk = 200000,
                ItemLevel = 18,
                GradeId = ItemGrades.Instances.HighGrade.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("550f5d33-ba62-4b4f-94fb-46254acac5fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 555
            };
        }
    }
}
