using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("a40b7714-5bd4-4aa7-a14a-4be9ce4efdb7"), Type = TextBlockType.Text, Text = "You scramble a creature's mental faculties and sensory input. The target must attempt a Will saving throw. Regardless of the result of that save, the target is then temporarily immune for 10 minutes. Warp mind's effects happen instantly, so dispel magic and other effects that counteract spells can't counteract them. However, alter reality, miracle, primal phenomenon, restoration, or wish can still counteract the effects." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("178e44c5-1620-461e-8e82-963fb6c5df8b"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("d78fd791-48f4-4940-9d71-b965ce9568e6"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ffc8bec4-a201-42ed-8029-5d45466085ed"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("599addb2-cdae-4309-b5da-00a60d1ab420"), Traits.Instances.Mental.ID);
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
