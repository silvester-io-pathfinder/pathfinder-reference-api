using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AlarmSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "No Action";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa"),
                Name = "Alarm",
                CastTime = TimeSpan.FromMinutes(10),
                Duration = "8 hours.",
                Range = 0,
                Level = 1,
                Area = "20-foot burst"
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ee60bac-8c15-4585-ba13-ddabd9564658"), Type = Utilities.Text.TextBlockType.Text, Text = "You ward an area to alert you when creatures enter without your permission. When you cast alarm, select a password. Whenever a Small or larger corporeal creature enters the spell’s area without speaking the password, alarm sends your choice of a mental alert (in which case the spell gains the mental trait) or an audible alarm with the sound and volume of a hand bell (in which case the spell gains the auditory trait). Either option automatically awakens you, and the bell allows each creature in the area to attempt a DC 15 Perception check to wake up. A creature aware of the alarm must succeed at a Stealth check against the spell’s DC or trigger the spell when moving into the area." };
        }

        public override IEnumerable<SpellRequirement> GetRequirements()
        {
            yield return new SpellRequirement { Id = Guid.Parse("c631f94d-c9e7-41d0-bf15-20d3afd682c2"), Text = "3 gp" };
            yield return new SpellRequirement { Id = Guid.Parse("7febd529-e31e-46b6-ab97-ed86dfeedf74"), Text = "Silver Bell" };
            yield return new SpellRequirement { Id = Guid.Parse("e1b278cb-b19d-416e-bb43-1fc017ff681a"), Text = "Focus" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("730097a4-0886-4c81-a15e-b00fc7ec40c9"),
                Level = 3,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("569c330e-2a24-4278-ab38-f238d36ce0b3"), Type = Utilities.Text.TextBlockType.Text, Text = "You can specify criteria for which creatures sound the alarm spell—for instance, orcs or masked people." }
                }
            };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
            yield return "Material";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Divine";
            yield return "Occult";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Abjuration";
        }
    }
}
