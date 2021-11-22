using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MimicUndead : Template
    {
        public static readonly Guid ID = Guid.Parse("95edfd34-d62d-4a20-9807-d4c42759f937");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mimic Undead",
                Level = 2,
                Requirements = "You're a living creature.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("27e9dbb0-851a-4d71-93a2-29cbc9b8f669"), Type = TextBlockType.Text, Text = "You take death and wrap it about you like a cloak�your colors wash out and your skin grows cold to the touch. Your heartbeat, breathing, and similar life functions become very difficult to detect. Senses such as lifesense detect you as undead unless a creature succeeds at a Perception check against the spell�s DC, and on a failed check, they don�t detect you at all if they only sense living creatures. Detection spells that specifically sense living creatures must succeed at a counteract check against mimic undead to detect you. You gain a +4 status bonus to Impersonate an undead but physically intact version of yourself and can add your level as your proficiency bonus even if you�re untrained. You don�t gain these benefits to Impersonate any other sort of undead. Mindless undead usually don�t have a reason to even attempt the Perception check to notice your Impersonation unless you interact with them in some way." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
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
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c494c0a7-39de-486d-a648-8bb968a95cc8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 115
            };
        }
    }
}
