using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ArmorOfBones : Template
    {
        public static readonly Guid ID = Guid.Parse("17af2ab4-8d16-46bf-a26a-dc1865b7fb68");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Armor of Bones",
                Level = 3,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c5ba88e-35d9-44f9-b64f-a8a855e83cdf"), Type = TextBlockType.Text, Text = "You ossify your physical form, mimicking the durability of bone. You gain resistance 3 to cold, electricity, fire, piercing, and slashing damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("222ea1b0-7fda-4a45-bf06-2f12f59255f4"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("57244588-724a-4092-9b8e-0320fc75fb08"), Type = TextBlockType.Text, Text = "Increase the resistance by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("17270046-92bf-43b9-9cbd-8c81644aa555"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b3b7cf05-cfcd-4ffd-b20f-aa8993410fee"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("d07e131d-c065-4bf9-b344-f643dac20cbe"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("b2e610e5-91b4-46ae-842a-4a5fe000459e"), Traits.Instances.Oracle.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("086d4bbb-2ff5-474e-b5bf-aad0719e1332"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
