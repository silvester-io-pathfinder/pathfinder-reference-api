using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WarriorsRegret : Template
    {
        public static readonly Guid ID = Guid.Parse("dde0edf2-2b1b-49a1-ada7-86ec332dce91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Warrior's Regret",
                Level = 140,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac436ccd-0fdc-4a28-be19-5e6236992a20"), Type = TextBlockType.Text, Text = "Regret eats away at the target's mind, punishing it for its violence until it ceases its hostility. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d619f210-112e-4bd3-ae22-863129b274bd"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("aa15a21f-f4e1-4759-aa0c-616a192bfef3"), Type = TextBlockType.Text, Text = "The amount of mental damage the target takes for each creature it damaged that turn increases by 1d8, and the maximum damage the target can take per turn increases by 4d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("fe06f8cf-ab5e-4f5f-9791-6de59e7f4ff4"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "At the end of its next turn, the target takes 1d8 damage per different creature it intentionally damaged on that turn (1d8 if it damaged one creature, 2d8 if it damaged two different creatures, and so on). The maximum is 4d8 if it damaged 4 different creatures.",
                Failure = "As success, except the curse damages the target at the end of each of its turns and lasts until the target spends a complete round without intentionally damaging another creature.",
                CriticalFailure = "As success, except the curse damages the target at the end of each of its turns and lasts until the target spends 24 hours atoning for its perceived sins."
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2a8e3255-7e36-4087-80e8-5c4730cb6406"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("91fde4b1-3527-4c6c-b328-5953a25ad251"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("7af6e7d7-a88d-40e7-91b0-057213e2efba"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("57f677ca-7dac-494d-ad93-2c13afaaccf5"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a5c6bdf-8b6e-450c-963b-cf39589656fb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 140
            };
        }
    }
}
