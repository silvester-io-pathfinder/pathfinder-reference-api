using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GlimmerOfCharm : Template
    {
        public static readonly Guid ID = Guid.Parse("475e2bdb-ba7d-4357-8aca-7b6aa146e188");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Glimmer of Charm",
                Level = 5,
                Duration = "Sustained up to 1 minute.",
                Area = "20-foot emanation centered on you.",
                IsDismissable = true,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0b20634-b642-4ca0-8008-09a34d848152"), Type = TextBlockType.Text, Text = "You�re bathed in a smooth, almost glittering aura that improves the attitude of those near you. Any creature that ends its turn in the aura must attempt a Will saving throw with the following effects. No matter the result, it�s then temporarily immune for 24 hours. The effect lasts until the spell ends, even after the creature leaves the aura." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("49ddacf0-4e1c-4661-b9a2-e2c4d8a9b3ba"),
                CriticalSuccess = "The creature is unaffected and is aware of the aura.",
                Success = "The creature�s attitude toward you improves by one step. If that improves its attitude to at least indifferent, it can�t take hostile actions against you, though the effect ends as soon as you take a hostile action against the creature or its allies.",
                Failure = "The creature�s attitude toward you improves by two steps. It can�t take hostile actions against you, though the effect ends as soon as you take a hostile action against the creature or its allies.",
                CriticalFailure = "The creature�s attitude becomes helpful to you, though the effect ends as soon as you take a hostile action against the creature or its allies. While the creature is helpful, it can�t take hostile actions against you."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Aura.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0b539db-abda-4c24-b9ba-eddcae792d8e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 108
            };
        }
    }
}
