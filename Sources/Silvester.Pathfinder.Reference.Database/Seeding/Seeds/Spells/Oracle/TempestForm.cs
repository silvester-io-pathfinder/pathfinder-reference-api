using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TempestForm : Template
    {
        public static readonly Guid ID = Guid.Parse("41d86bba-5c5a-466a-8818-1cbf4c94081b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tempest Form",
                Level = 6,
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6f9564e0-c47d-4192-9cbe-f41fe253cb24"), Type = TextBlockType.Text, Text = "Your body becomes fluid to better suit your surroundings. When you Cast this Spell, choose whether to become air, water, or mist. The spell gains the air trait if you choose air or mist, and the water trait if you choose water or mist. You become amorphous, as does your armor. You lose any item bonus to AC and use your proficiency bonus for unarmored defense to determine your AC. You also gain resistance 10 to physical damage and become immune to precision damage. You can slip through tiny cracks and don’t need to breathe. You can’t cast spells, activate items, or use actions that have the attack or manipulate trait. You also gain the following effects based on your form." };
            yield return new TextBlock { Id = Guid.Parse("f7b5b85a-4fdc-47e9-b38b-c0088580988c"), Type = TextBlockType.Enumeration, Text = "Air - You gain a fly Speed of 20 feet and become invisible while you are in the air. You can create the effects of a gust of wind from your space as a 2-action activity, which has the manipulate trait." };
            yield return new TextBlock { Id = Guid.Parse("18a93616-f712-4d75-9e2c-d7fcd461444f"), Type = TextBlockType.Enumeration, Text = "Mist - You gain a fly Speed of 20 feet, and it becomes hard to see through you. Any creature on one side of your space who is targeted by a creature on the opposite side is concealed to the targeting creature." };
            yield return new TextBlock { Id = Guid.Parse("25742ad7-797e-41df-8e31-87b5dcb061ee"), Type = TextBlockType.Enumeration, Text = "Water - You gain a swim Speed of 20 feet and become invisible while you are in the water. You can electrically charge yourself by taking a single action, which has the manipulate trait. If you do, you are no longer invisible in the water due to electricity indicating your location, but any creature that makes a melee attack against you takes 1d6 electricity damage; if it touches you, this is cumulative with the damage from your major curse." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("444ae0af-c0bd-4ac3-bf3e-128a9d80c53f"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a5174a13-ceda-4602-9c3f-6f99ef70a04f"), Type = TextBlockType.Text, Text = "Increase the resistance by 5 and the electricity damage from the charged water form by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b613dd04-dc4a-4fad-85d4-b4743ac76d79"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 233
            };
        }
    }
}
