using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MirrorsMisfortune : Template
    {
        public static readonly Guid ID = Guid.Parse("bdceac42-ce0c-4e06-8225-baa31140dbca");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mirror's Misfortune",
                Level = 4,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("12674d9e-b729-4716-b349-203a7068df2d"), Type = TextBlockType.Text, Text = "You split into your real self and a mirrored version of yourself that curses would-be attackers with misfortune on their next attacks. When you cast this spell, you seem to split in two. As you do, you can Step to any adjacent square. In either your initial square, or another square adjacent to your initial square, an exact illusory duplicate of you appears. You decide a simple course of action for the duplicate to follow, such as to walk to a specific point or wave its hands in the air, but more complex routines are beyond its abilities. A creature can distinguish between you and the duplicate only if it spends an action to Seek and succeeds at a Perception check against the spell's DC." };
            yield return new TextBlock { Id = Guid.Parse("e34026aa-38c4-4355-9169-5e4e125ffe55"), Type = TextBlockType.Text, Text = "If a creature takes a hostile action against the duplicate, the illusion shatters into mirrorlike shards, inflicting bad luck on the attacker's next few attacks as misfortune's toll for shattering the mirror. The attacker must attempt a Will save with the following effects; this is a curse and misfortune effect. When the duplicate shatters, the spell ends." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6cb63cc5-4186-4a38-9698-acaf1ec04ae4"),
                Success = "The creature is unaffected.",
                Failure = "Within the next hour, the creature must roll its next two attack rolls twice and take the lower result.",
                CriticalFailure = "Within the next hour, the creature must roll its next four attack rolls twice and take the lower result."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ebe5f6d9-ac30-4980-9890-29517863cb34"), Traits.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0afb5eaf-f23c-4d0c-9688-4040d2a4779b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 117
            };
        }
    }
}
