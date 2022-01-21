using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SynapticPulse : Template
    {
        public static readonly Guid ID = Guid.Parse("2c83b759-23b2-4368-a7a5-a451c3f85b76");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Synaptic Pulse",
                Level = 5,
                Range = "30 feet.",
                Area = "30-foot emanation.",
                Duration = "1 round.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2daafe7-70ca-4761-8c8f-a5e51ff0e517"), Type = TextBlockType.Text, Text = "You emit a pulsating mental blast that penetrates the minds of all enemies in the area. Each creature in the area must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("9ec7ddc4-b0cb-4f5e-8792-d9ea199f8021"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is stunned 1.",
                Failure = "The creature is stunned 2.",
                CriticalFailure = "The creature is stunned for 1 round."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("22b5ae6c-c40b-4ba6-8747-41a95c88126c"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("997b723b-e1d8-4b30-aedd-be9eb787dc91"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("2040a3f5-7075-4085-a911-067765b1f391"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b668e4a-4f9a-4969-90ac-7a245512761f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 376
            };
        }
    }
}
