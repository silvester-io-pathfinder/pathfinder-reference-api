using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnspeakableShadow : Template
    {
        public static readonly Guid ID = Guid.Parse("67360a72-de62-4faf-a948-608e8747b9f3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unspeakable Shadow",
                Level = 9,
                Range = "120 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c3ab431-4fb5-4f53-96e3-1ecec25f9bf7"), Type = TextBlockType.Text, Text = "You alter a creature�s shadow, transforming it into a terrifying monster out to devour the creature. The creature must attempt a Will save. A creature that has the frightened condition from unspeakable shadow must spend at least one of its actions each turn to either attack its shadow (making a Strike ineffectually) or flee from its shadow (using one action to move away as though it had the fleeing condition)." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("9625aeeb-48f6-4b91-af79-6e782cfbd330"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target is frightened 2.",
                Failure = "The target is frightened 3. It can�t reduce its frightened value below 1 for 1 minute.",
                CriticalFailure = "The target is so afraid, it might instantly die. It must succeed at a Fortitude save or die; this saving throw has the incapacitation trait. If it succeeds at its save, the target is frightened 4 and can�t reduce its frightened value below 1 for 1 minute."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Shadow.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("983163ae-f3f9-4087-b35e-8b17627ec7d4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 138
            };
        }
    }
}
