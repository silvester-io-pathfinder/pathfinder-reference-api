using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VibrantPattern : Template
    {
        public static readonly Guid ID = Guid.Parse("f6c126fd-db6b-49bf-8439-7da6cf8b442f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vibrant Pattern",
                Level = 6,
                Range = "120 feet.",
                Area = "10-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d4699d0-7437-4684-b08f-b8fec907ea61"), Type = TextBlockType.Text, Text = "You create a pattern of lights that pulses with intensity. Creatures are dazzled while inside the pattern." };
            yield return new TextBlock { Id = Guid.Parse("51cb811e-7a24-456a-8451-b5ff28641856"), Type = TextBlockType.Text, Text = "In addition, a creature must attempt a Will saving throw if it’s inside the pattern when you cast it, enters the pattern, ends its turn within the pattern, or uses a Seek or Interact action on the pattern. A creature currently blinded by the pattern doesn’t need to attempt new saving throws." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("48f59a2c-c88a-4691-a845-ce2560099c6f"),
                CriticalSuccess = "",
                Success = "The creature is unaffected.",
                Failure = "The creature is blinded by the pattern. If it exits the pattern, it can attempt a new save to recover from the blinded condition at the end of each of its turns, to a maximum duration of 1 minute.",
                CriticalFailure = "The creature is blinded for 1 minute."
            };
        }


        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69ee06c5-dbc7-4c25-9904-d3398467bfd0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 381
            };
        }
    }
}
