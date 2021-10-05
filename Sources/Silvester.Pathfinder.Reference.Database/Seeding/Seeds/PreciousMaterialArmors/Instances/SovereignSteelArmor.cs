using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PreciousMaterialArmors.Instances
{
    public class SovereignSteelArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("73db3bdd-bc32-4a6d-9c21-580d3301e6ec");

        protected override PreciousMaterialArmor GetArmor()
        {
            return new PreciousMaterialArmor
            {
                Id = ID,
                Name = "Sovereign Steel Armor",
                MaterialId = PreciousMaterials.Instances.SovereignSteel.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bf939410-b553-4edc-a4e5-44e7cc82002f"), Type = TextBlockType.Text, Text = "Sovereign steel armor sickens certain creatures that touch it. A creature with weakness to cold iron that critically fails an unarmed attack against a creature in sovereign steel armor becomes sickened 1, and such a creature is sickened 1 as long as it wears sovereign steel armor. The noqual in sovereign steel armor provides protection against magic, granting you a +1 circumstance bonus to AC against spell attack rolls. If you Cast a Spell while wearing sovereign steel armor, you must succeed at a DC 5 flat check or the spell fails." };
        }

        protected override IEnumerable<PreciousMaterialArmorVariant> GetVariants()
        {
            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("d680bbcb-0187-45ca-a608-5baffd20aa18"),
                CraftRequirements = "At least 150 gp of cold iron + 15 gp per Bulk plus at least 150 gp of noqual + 15 gp per Bulk.",
                Price = 240000,
                AdditionalPricePerBulk = 24000,
                ItemLevel = 13,
                GradeId = ItemGrades.Instances.StandardGrade.ID
            };

            yield return new PreciousMaterialArmorVariant
            {
                Id = Guid.Parse("eee06ecd-eefe-4dbf-84c1-2ef32026a7e6"),
                CraftRequirements = "At least 12,500 gp of cold iron + 1,250 gp per Bulk plus at least 12,500 gp of noqual + 1,250 gp per Bulk.",
                Price = 5000000,
                AdditionalPricePerBulk = 500000,
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
                Id = Guid.Parse("1966ddf8-0583-453a-85cc-08c79a70ca75"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 77
            };
        }
    }
}
