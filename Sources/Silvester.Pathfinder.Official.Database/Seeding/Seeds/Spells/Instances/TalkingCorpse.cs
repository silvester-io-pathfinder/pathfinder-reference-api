using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TalkingCorpse : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Talking Corpse",
                Level = 4,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 corpse.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You grant the target corpse a semblance of life, which it uses to speak the answers to three questions posed to it. This spell calls on the physical body’s latent memories rather than summoning back the deceased’s spirit, so the corpse must be mostly intact for the spell to function. The more damage the corpse has taken, the more inaccurate or patchwork its answers are, and it must have a throat and mouth to speak at all. If anyone has previously cast this spell on the corpse in the last week, the spell automatically fails. The corpse can attempt a Will save to resist answering the questions using the statistics of the original creature at its time of death, with the following effects." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target can lie or refuse to answer your questions, and the target’s spirit haunts you for 24 hours, bothering you and causing you to be unable to gain any rest for that time.",
                Success = "The target can provide false information or refuse to answer your questions.",
                Failure = "The target must answer truthfully, but its answers can be brief, cryptic, and repetitive. It can still mislead you or attempt to stall so that the spell’s duration runs out before you can ask all your questions.",
                CriticalFailure = "As failure, but the target’s answers are more direct and less repetitive, though still cryptic. It takes a –2 status penalty to Deception checks to deceive or mislead you."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
