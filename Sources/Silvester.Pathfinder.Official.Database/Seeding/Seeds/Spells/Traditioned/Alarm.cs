using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Alarm : Template
    {
        public static readonly Guid ID = Guid.Parse("558a6ae1-fc9f-4e11-9c93-18d52be7f5aa");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Alarm",
                CastTime = "10 minutes.",
                Duration = "8 hours.",
                Range = "Touch.",
                Level = 1,
                Area = "20-foot burst",
                Requirements = "3 gp, one Silver Bell and Focus.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ee60bac-8c15-4585-ba13-ddabd9564658"), Type = Utilities.Text.TextBlockType.Text, Text = "You ward an area to alert you when creatures enter without your permission. When you cast alarm, select a password. Whenever a Small or larger corporeal creature enters the spell’s area without speaking the password, alarm sends your choice of a mental alert (in which case the spell gains the mental trait) or an audible alarm with the sound and volume of a hand bell (in which case the spell gains the auditory trait). Either option automatically awakens you, and the bell allows each creature in the area to attempt a DC 15 Perception check to wake up. A creature aware of the alarm must succeed at a Stealth check against the spell’s DC or trigger the spell when moving into the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("730097a4-0886-4c81-a15e-b00fc7ec40c9"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("569c330e-2a24-4278-ab38-f238d36ce0b3"), Type = Utilities.Text.TextBlockType.Text, Text = "You can specify criteria for which creatures sound the alarm spell—for instance, orcs or masked people." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
            yield return SpellComponents.Instances.Material.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 317
            };
        }
    }
}
