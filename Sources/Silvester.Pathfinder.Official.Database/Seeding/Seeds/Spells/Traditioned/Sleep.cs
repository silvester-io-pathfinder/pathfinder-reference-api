using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Sleep : Template
    {
        public static readonly Guid ID = Guid.Parse("a2b0b58b-19a9-454d-9cf0-81c74d1301a2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sleep",
                Level = 1,
                Range = "30 feet.",
                Area = "5-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68810aee-e637-4b91-bd8d-75ace196b201"), Type = TextBlockType.Text, Text = "Each creature in the area becomes drowsy and might fall asleep. A creature that falls unconscious from this spell doesn’t fall prone or release what it’s holding. This spell doesn’t prevent creatures from waking up due to" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("538603e6-7079-48cd-b856-3fd688b00e91"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f867dd5b-0023-4abb-97fa-46e0371386b7"), Type = TextBlockType.Text, Text = "The creatures fall unconscious for 1 round on a failure or 1 minute on a critical failure. They fall prone and release what they’re holding, and they can’t attempt Perception checks to wake up. When the duration ends, the creature is sleeping normally instead of automatically waking up." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("5ffadddc-181f-40b7-abee-214ed2d489a4"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes a –1 status penalty to Perception checks for 1 round.",
                Failure = "The creature falls unconscious. If it’s still unconscious after 1 minute, it wakes up automatically.",
                CriticalFailure = "The creature falls unconscious. If it’s still unconscious after 1 hour, it wakes up automatically."
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
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sleep.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31a4c885-87cf-4764-bd37-66841e2ce0ec"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
