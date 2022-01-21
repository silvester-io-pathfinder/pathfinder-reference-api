using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SoundBurst : Template
    {
        public static readonly Guid ID = Guid.Parse("039ee5fe-341b-4de5-bdec-462a495fce1d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sound Burst",
                Level = 2,
                Range = "30 feet.",
                Area = "10-foot burst.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("086a81c2-906f-4425-8859-811d6c32b979"), Type = TextBlockType.Text, Text = "A cacophonous noise blasts out, dealing 2d10 sonic damage. Each creature must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3ffecc24-d21f-4568-bc85-7a5eae9b898c"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("434978e5-c09a-4d6d-b8ee-544362f4c1df"), Type = TextBlockType.Text, Text = "The damage increases by 1d10." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f603ead2-0a9f-4f7c-8ad5-cc7f154a49a9"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is deafened for 1 round.",
                CriticalFailure = "The creature takes double damage, is deafened for 1 minute, and is stunned 1."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("161c83e3-7d79-40b1-91be-eeb77f47259c"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("784b6b9a-fb30-490f-87c2-75a99df94b73"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18a7fa18-22d9-42ff-865c-1b4185fdbe8f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
