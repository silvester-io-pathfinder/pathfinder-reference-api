using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
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
                MysteryId = Mysteries.Instances.Bones.ID,
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Oracle.ID;
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
