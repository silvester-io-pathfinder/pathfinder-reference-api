using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CurseOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Curse of Death",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You focus your malevolent gaze on a target, causing their heart to seize in dread. The target must attempt a Fortitude saving throw. Regardless of the result, the target is temporarily immune to further castings of curse of death for 1 day." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Increase the negative damage taken on a success and during the first three stages of the curse by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is afflicted with the curse of death at stage 1, and the stage of the curse can’t increase beyond stage 1.",
                Failure = "The target is afflicted with the curse of death at stage 1.",
                CriticalFailure = "The target is afflicted with the curse of death at stage 2."
            };
        }

        protected override IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield return new StaggeredEffect
            {
                Id = Guid.Parse(""),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "1 minute.",
                Onset = "Immediate.",
                Addendum = "This curse ends immediately when the spell end.",
                Level = 5,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect{ Id = Guid.Parse(""), Damage = "4d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Fatigued.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect{ Id = Guid.Parse(""), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Fatigued.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect{ Id = Guid.Parse(""), Damage = "12d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Fatigued.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 round",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Dead.ID}
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
