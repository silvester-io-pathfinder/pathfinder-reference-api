using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class GhoulishCravings : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ghoulish Cravings",
                Level = 2,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You touch the target to afflict it with ghoul fever, infesting it with hunger and a steadily decreasing connection to positive energy; the target must attempt a Fortitude save." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is afflicted with ghoul fever at stage 1.",
                Failure = "The target is afflicted with ghoul fever at stage 2.",
                CriticalFailure = "The target is afflicted with ghoul fever at stage 3."
            };
        }

        protected override IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield return new StaggeredEffect
            {
                Id = Guid.Parse(""),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "6",
                Onset = "Immediate",
                Level = 3,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 day.",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Carrier.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse(""), Damage = "2d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse(""), Effect = "The creature regains half as many Hit Points from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse(""), Damage = "2d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse(""), Effect = "The creature regains half as many Hit Points from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse(""), Damage = "3d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse(""), Effect = "The creature gains no benefit from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 day.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse(""), Damage = "3d8", DamageTypeId = DamageTypes.Instances.Negative.ID },
                            new OtherEffect {Id = Guid.Parse(""), Effect = "The creature gains no benefit from healing."},
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse(""),
                        Duration = "1 day.",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse(""), ConditionId = Conditions.Instances.Dead.ID},
                            new OtherEffect { Id = Guid.Parse(""), Effect = "The creature rises as a ghoul at the next midnight." }
                        }
                    },
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Evil.ID;
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
