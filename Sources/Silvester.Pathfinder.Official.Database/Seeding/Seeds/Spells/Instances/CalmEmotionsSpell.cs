using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CalmEmotionsSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("3a2a1f6e-f8d9-465d-94cc-1253a5c42062");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Calm Emotions",
                Level = 2,
                Range = 120,
                Area = "10-foot burst.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c1b6683-6bf3-4d9a-849c-9bf062facf3c"), Type = Utilities.Text.TextBlockType.Text, Text = "You forcibly calm creatures in the area, soothing them into a nonviolent state; each creature must attempt a Will save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ca435a76-e666-4d33-8087-ca973e4cd537"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "Calming urges impose a –1 status penalty to the creature’s attack rolls.",
                Failure = "Any emotion effects that would affect the creature are suppressed and the creature can’t use hostile actions. If the target is subject to hostility from any other creature, it ceases to be affected by calm emotions.",
                CriticalFailure = "As failure, but hostility doesn’t end the effect."
            };
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
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }
    }
}
