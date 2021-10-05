using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CaptivatingAdoration : Template
    {
        public static readonly Guid ID = Guid.Parse("dc2be0a2-7409-4d88-8449-8b9557854c1a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Captivating Adoration",
                Level = 4,
                Area = "15-foot emenation.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Passion.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7684a9a2-0391-481c-97fd-381a3764d20e"), Type = TextBlockType.Text, Text = "You become intensely entrancing, and creatures are distracted by you as long as they remain within the area. You can exclude any creatures you choose from the effects." };
            yield return new TextBlock { Id = Guid.Parse("8d6f3de3-30e7-4401-881a-483a5f4ce195"), Type = TextBlockType.Text, Text = "When a creature enters the area for the first time, it must attempt a Will saving throw. If a creature leaves and reenters, it uses the results of its original save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0485b230-485c-4bd8-bbda-81f6efc5cd77"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6042b575-cda1-4af8-add2-092bad2b90d9"), Type = TextBlockType.Text, Text = "Increase the size of the emanation by 15 feet." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("5fdcb111-4315-42b1-a309-22953326528f"),
                CriticalSuccess = "The creature is unaffected and temporarily immune for 1 hour.",
                Success = "The creature is fascinated with you for its next action, then is temporarily immune for 1 hour.",
                Failure = "The creature is fascinated with you.",
                CriticalFailure = "The creature is fascinated with you, and its attitude toward you improves by one step."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0055e08b-9945-4fdc-944b-7ed1c131c615"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 389
            };
        }
    }
}
