using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class OrichalcumArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("1287dbd8-558a-4c7f-bf2a-37dbe34e802c");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Orichalcum Armor",
                MaterialId = PreciousMaterials.Instances.Orichalcum.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("213a69bc-1e87-4418-99b0-3a994f95de5c"), Type = TextBlockType.Text, Text = "Orichalcum armor can be etched with four magic property runes instead of three due to the magical empowerment of orichalcum. If you are wearing armor made of orichalcum, the armor grants you insights into the future, granting you a +1 circumstance bonus to initiative rolls." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("e6c574cf-01f8-4455-ad33-7bf05fa1a52a"),
                CraftRequirements = "The initial raw materials must include orichalcum worth at least 27,500 gp + 2,750 gp per Bulk.",
                Price = 5500000,
                AdditionalPricePerBulk = 550000,
                ItemLevel = 20,
                GradeId = ItemGrades.Instances.HighGrade.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Rare.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c376c2d-62ef-4156-8e8f-0c98c1218d3d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 556
            };
        }
    }
}
