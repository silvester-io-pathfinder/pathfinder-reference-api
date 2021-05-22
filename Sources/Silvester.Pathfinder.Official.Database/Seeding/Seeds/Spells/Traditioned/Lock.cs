using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Lock : Template
    {
        public static readonly Guid ID = Guid.Parse("4d43a965-8383-4cf7-a31d-57dd72a2a5a4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lock",
                Level = 1,
                Range = "Touch.",
                Duration = "1 day.",
                Targets = "1 lock, or a door or container with a latch.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fabaf608-b4e1-4783-982a-b7862fbfac48"), Type = TextBlockType.Text, Text = "The target’s latch mechanism clinks shut, held fast by unseen magical restraints. When you magically lock a target, you set an Athletics and Thievery DC to open it equal to your spell DC or the base lock DC with a +4 status bonus, whichever is higher. Any key or combination that once opened a lock affected by this spell does not do so for the duration of the spell, though the key or combination does grant a +4 circumstance bonus to checks to open the door." };
            yield return new TextBlock { Id = Guid.Parse("01c80245-9ff1-4d94-9c91-b821cc6933f7"), Type = TextBlockType.Text, Text = "If the target is opened, the spell ends. Assuming the target is not barred or locked in some additional way, you can unlockand open it with an Interact action during which you touch the target. This does not end the spell. You can Dismiss this spell at any time and from any distance." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a6daaee0-4c78-4586-b296-c49cefe9869b"), 
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a2c6c94e-9486-475b-b878-820130eff361"), Type = TextBlockType.Text, Text = "The duration increases to unlimited, but you must expend 6 gp worth of gold dust as an additional cost." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bb901f8-872e-4cbe-b10a-661f219d2210"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
