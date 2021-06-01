using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class SilverArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("485becdc-d5e9-4ff1-a879-4419d9de8189");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Silver Armor",
                MaterialId = PreciousMaterials.Instances.Silver.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e04ac5f2-e46c-4765-9ea3-62c9aabe95bd"), Type = TextBlockType.Text, Text = "Silver armor sickens certain creatures that touch it. A creature with weakness to silver that critically fails an unarmed attack against a creature in silver armor becomes sickened 1. A creature with weakness to silver is sickened 1 as long as it wears silver armor." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("6e876c53-e7ed-450b-b145-ff18dcbfcc4a"),
                CraftRequirements = "Silver worth at least 70 sp + 7 sp per Bulk.",
                Price = 14000,
                AdditionalPricePerBulk = 1400,
                ItemLevel = 5,
                GradeId = ItemGrades.Instances.LowGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("68712a71-5b2f-4a27-a28d-a56048a6c728"),
                CraftRequirements = "The initial raw materials must include silver worth at least 150 gp + 15 gp per Bulk.",
                Price = 120000,
                AdditionalPricePerBulk = 12000,
                ItemLevel = 11,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("5700798e-d3c0-49a3-b490-7baf1d37e2ea"),
                CraftRequirements = "The initial raw materials must include silver worth at least 10,000 gp + 1,000 gp per Bulk.",
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
                Id = Guid.Parse("67529de1-a69e-4945-8d06-98f42ef270fa"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 556
            };
        }
    }
}
