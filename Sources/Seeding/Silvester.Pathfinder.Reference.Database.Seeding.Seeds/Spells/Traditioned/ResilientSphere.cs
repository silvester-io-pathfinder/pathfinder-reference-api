using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ResilientSphere : Template
    {
        public static readonly Guid ID = Guid.Parse("6007e524-204d-451d-87b1-7f3fc7646ee5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Resilient Sphere",
                Level = 4,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 Large or smaller creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09185ac4-2fc9-4e4f-91eb-8d76ea9a5021"), Type = TextBlockType.Text, Text = "You create an immobile sphere of force to either trap or protect the target, blocking anything that would pass through the sphere. The sphere has AC 5, Hardness 10, and 40 Hit Points. It's immune to critical hits and precision damage. Disintegrate destroys the sphere instantly. If the target is unwilling, the effects of the sphere depend on the target's Reflex save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("01b06dbe-0d2e-4f94-af09-883d2a79e058"),
                CriticalSuccess = "The target disrupts the sphere's integrity, causing it to collapse entirely.",
                Success = "The sphere functions normally but has only 10 Hit Points instead of 40.",
                Failure = "The sphere has its normal effect.",
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
            builder.Add(Guid.Parse("622a0651-9df3-4f92-9ae5-5cd68d051b80"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("8d312988-f1c5-4877-8f8b-8e5c2ff4bd2a"), Traits.Instances.Force.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("007d3dd4-c582-45ba-b97e-b627de15adea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 364
            };
        }
    }
}
