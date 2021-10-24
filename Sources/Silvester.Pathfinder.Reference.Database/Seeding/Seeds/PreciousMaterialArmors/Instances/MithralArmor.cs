using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class MithralArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("afc82eed-f33e-43c6-af78-3c6c6406692f");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Mithral Armor",
                MaterialId = PreciousMaterials.Instances.Mithral.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("29117c5a-d2ee-4f7c-b39e-2fab654a03b5"), Type = TextBlockType.Text, Text = "Mithral armor is 1 Bulk lighter than normal (or light Bulk if its normal Bulk is 1, with no effect on armor that normally has light Bulk). It’s easier to wear than normal metal armor, reducing the Strength score necessary to ignore its check penalty by 2 and reducing its Speed penalty by 5 feet." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("4db5a4e3-0150-4114-b34e-39086d892991"),
                CraftRequirements = "The initial raw materials must include mithral worth at least 200 gp + 20 gp per Bulk.",
                Price = 160000,
                AdditionalPricePerBulk = 16000,
                ItemLevel = 12,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("8d74d222-4bd5-4c2b-919a-a89afa9c95f9"),
                CraftRequirements = "The initial raw materials must include mithral worth at least 16,000 gp + 1,600 gp per Bulk.",
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
                Id = Guid.Parse("27d62751-2930-449f-a6db-630947375bd1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 556
            };
        }
    }
}
