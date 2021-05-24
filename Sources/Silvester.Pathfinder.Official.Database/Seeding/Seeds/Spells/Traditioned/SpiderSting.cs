using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiderSting : Template
    {
        public static readonly Guid ID = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spider Sting",
                Level = 1,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"), Type = TextBlockType.Text, Text = "You magically duplicate a spider’s venomous sting. You deal 1d4 piercing damage to the touched creature and afflict it with spider venom. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 1d4 poison damage.",
                Failure = "The target is afflicted with spider venom at stage 1.",
                CriticalFailure = "The target is afflicted with spider venom at stage 2."
            };
        }

        protected override StaggeredEffect GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"),
                Addendum = "Spider Venom",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "4 rounds.",
                Onset = "Immediate",
                Level = 1,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"),
                        Duration = "1 round.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"), Damage = "1d4", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"),
                        Duration = "1 round.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"), Damage = "1d4", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 2}
                        }
                    }
                }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04f72455-2575-49a9-b1c0-43d0281a2766"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
