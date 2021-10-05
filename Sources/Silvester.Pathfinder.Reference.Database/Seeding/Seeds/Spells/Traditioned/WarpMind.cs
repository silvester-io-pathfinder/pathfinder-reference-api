using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WarpMind : Template
    {
        public static readonly Guid ID = Guid.Parse("ec9aaa24-7288-4ab5-9f9f-f8c964f554b8");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Warp Mind",
                Level = 7,
                Range = "120 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a40b7714-5bd4-4aa7-a14a-4be9ce4efdb7"), Type = TextBlockType.Text, Text = "You scramble a creature’s mental faculties and sensory input. The target must attempt a Will saving throw. Regardless of the result of that save, the target is then temporarily immune for 10 minutes. Warp mind’s effects happen instantly, so dispel magic and other effects that counteract spells can’t counteract them. However, alter reality, miracle, primal phenomenon, restoration, or wish can still counteract the effects." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("aa8513c6-e602-4f03-9c9d-2d864b66ad8a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target spends the first action on its next turn with the confused condition.",
                Failure = "The target is confused for 1 minute.",
                CriticalFailure = "The target is confused permanently."
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
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("46dc1704-6c22-49eb-aa5b-a2c603c453ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 383
            };
        }
    }
}
