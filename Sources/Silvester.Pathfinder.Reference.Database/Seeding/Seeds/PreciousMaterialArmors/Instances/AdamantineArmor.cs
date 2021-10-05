using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class AdamantineArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("9c4884c6-39eb-4ed5-a3fb-d91f19e62f2f");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Adamantine Armor",
                MaterialId = PreciousMaterials.Instances.Adamantine.ID,
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("13483736-e390-494f-93ce-aa42d61ff128"), Type = TextBlockType.Text, Text = "Adamantine armor has a shiny, black appearance and is amazingly durable." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("9232f055-2f5a-49cc-af1e-038d1f51aeb3"),
                CraftRequirements = "The initial raw materials must include adamantine worth at least 200 gp + 20 gp per Bulk.",
                Price = 160000,
                AdditionalPricePerBulk = 16000,
                ItemLevel = 12,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("f2bf12b3-b976-4453-a60c-56c38e29cf0c"),
                CraftRequirements = "The initial raw materials must include adamantine worth at least 16,000 gp + 1,600 gp per Bulk.",
                Price = 3200000,
                AdditionalPricePerBulk = 320000,
                ItemLevel = 19,
                GradeId = ItemGrades.Instances.HighGrade.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6a1b803-8f1b-4a66-87fe-b13b79b2c308"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 555
            };
        }
    }
}
