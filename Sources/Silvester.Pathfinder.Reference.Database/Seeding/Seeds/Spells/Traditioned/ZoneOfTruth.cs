using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ZoneOfTruth : Template
    {
        public static readonly Guid ID = Guid.Parse("a1dc26d2-2300-40b1-a592-8e002bdad6f5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Zone of Truth",
                Level = 3,
                Range = "30 feet.",
                Area = "20-foot burst.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2aa1d392-5a57-44b2-8f01-4b68d85790fa"), Type = TextBlockType.Text, Text = "You designate an area in which creatures are compelled to speak only truth. Creatures within or entering the area have difficulty lying. Each potentially affected creature must attempt a Will save when the spell is cast or when the creature first enters the area. It uses the results of this initial save if it leaves and reenters the area. Affected creatures are aware of this enchantment; therefore, they can avoid answering questions to which they would normally respond with a lie, or they can be evasive as long as they remain within the boundaries of the truth." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("450c7565-cdd5-43e5-8684-556be2933a2a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes a –2 status penalty to Deception checks.",
                Failure = "The target can’t speak any deliberate and intentional lies, and it takes a –2 status penalty to Deception checks.",
                CriticalFailure = "The target can’t speak any deliberate and intentional lies and takes a –4 status penalty to Deception checks."
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9963f8f-ae1d-4592-bd6f-dda1048d62dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
