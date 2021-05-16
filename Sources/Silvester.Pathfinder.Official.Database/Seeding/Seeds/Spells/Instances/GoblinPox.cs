using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GoblinPox : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Goblin Pox",
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your touch afflicts the target with goblin pox, an irritating allergenic rash.The target must attempt a Fortitude save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is sickened 1.",
                Failure = "The target is afflicted with goblin pox at stage 1.",
                CriticalFailure = "The target is afflicted with goblin pox at stage 2."
            };
        }

        protected override IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield return new StaggeredEffect
            {
                Id = Guid.Parse(""),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "1 day.",
                Onset = "Immediate",
                Level = 1,
                Addendum = "Goblins and goblin dogs are immune.",
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 round.",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Sickened.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Sickened.ID, Severity = 1},
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Slowed.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Sickened.ID, Severity = 1},
                            new OtherEffect { Id = Guid.Parse(""), Effect = "The creature can't reduce its sickened value below 1."},
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
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 341
            };
        }
    }
}
