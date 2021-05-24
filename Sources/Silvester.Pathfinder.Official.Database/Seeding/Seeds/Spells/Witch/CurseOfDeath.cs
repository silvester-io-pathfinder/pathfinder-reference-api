using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CurseOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("6ca21150-65e1-4ef9-892d-9bda656316af");

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
            yield return new TextBlock { Id = Guid.Parse("7b39e399-5b1d-4ad3-9094-b0dcbd25ca15"), Type = TextBlockType.Text, Text = "You focus your malevolent gaze on a target, causing their heart to seize in dread. The target must attempt a Fortitude saving throw. Regardless of the result, the target is temporarily immune to further castings of curse of death for 1 day." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0010a970-fccc-43fc-8b5d-2b4012d88a84"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9529e1cb-2ccf-4ba0-a65b-3839539bac0f"), Type = TextBlockType.Text, Text = "Increase the negative damage taken on a success and during the first three stages of the curse by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d3ac62e5-f081-4c83-8c0d-37a3455254bf"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is afflicted with the curse of death at stage 1, and the stage of the curse can’t increase beyond stage 1.",
                Failure = "The target is afflicted with the curse of death at stage 1.",
                CriticalFailure = "The target is afflicted with the curse of death at stage 2."
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("ab0ff919-1a9e-48f1-bd34-756a8246f0d7"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "1 minute.",
                Onset = "Immediate.",
                Addendum = "This curse ends immediately when the spell end.",
                Level = 5,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("9d3a4778-0e99-4015-a880-d58167e71b18"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect{ Id = Guid.Parse("22641f43-f0fb-4cec-9546-3c8520b2ff76"), Damage = "4d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                            new ConditionEffect { Id = Guid.Parse("7bdec2f6-88fe-4bfa-9ad5-ceaab956bf2d"), ConditionId = Conditions.Instances.Fatigued.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("3554376c-54bd-420a-adc9-7ed9e06f2030"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect{ Id = Guid.Parse("8e43df59-8921-4500-ae7c-6dcd635d6b78"), Damage = "8d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                            new ConditionEffect { Id = Guid.Parse("decf27fc-3858-461b-8d04-7a2748530ed3"), ConditionId = Conditions.Instances.Fatigued.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("2299166a-99cc-47e1-ae3f-a5fe65822159"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect{ Id = Guid.Parse("8cffae7a-c754-4178-acf4-05f1fa93921b"), Damage = "12d6", DamageTypeId = DamageTypes.Instances.Negative.ID},
                            new ConditionEffect { Id = Guid.Parse("f53c466e-c240-42f8-baf8-94d7b9f39862"), ConditionId = Conditions.Instances.Fatigued.ID}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("3aa8341c-7be4-4198-a72f-d453cdad8c53"),
                        Duration = "1 round",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("cf0eedac-58be-4fe6-b179-f74e6e368c1c"), ConditionId = Conditions.Instances.Dead.ID}
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
                Id = Guid.Parse("3a1b9ee0-b566-4c8a-a452-91563b5d7d4d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
