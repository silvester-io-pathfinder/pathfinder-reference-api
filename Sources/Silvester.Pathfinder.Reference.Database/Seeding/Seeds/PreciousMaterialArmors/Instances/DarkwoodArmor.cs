using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class DarkwoodArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("c6ea2f2a-8c94-4e44-83be-e1a8a728d30c");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Darkwood Armor",
                MaterialId = PreciousMaterials.Instances.Darkwood.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f8ebd9fd-8cf4-4ba7-ae41-d9e9e79abdd9"), Type = TextBlockType.Text, Text = "Darkwood armor is 1 Bulk lighter than normal (or light Bulk if its normal Bulk is 1, with no effect on armor that normally has light Bulk). It’s easier to wear than normal wood armor, reducing the Strength score necessary to ignore its check penalty by 2 and reducing its Speed penalty by 5 feet. (There are no types of wood armor in this book)." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("255d5bed-1162-4cc8-ac66-7f535fa284ae"),
                CraftRequirements = "The initial raw materials must include darkwood worth at least 200 gp + 20 gp per Bulk.",
                Price = 160000,
                AdditionalPricePerBulk = 16000,
                ItemLevel = 12,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("36dfd451-492a-496e-84db-facc0329f357"),
                CraftRequirements = "The initial raw materials must include darkwood worth at least 16,000 gp + 1,600 gp per Bulk.",
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
                Id = Guid.Parse("39df8e05-0fca-4d3d-bc79-6551ce51f68c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 555
            };
        }
    }
}
