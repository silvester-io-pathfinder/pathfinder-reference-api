using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GoblinPox : Template
    {
        public static readonly Guid ID = Guid.Parse("4e7cb1a5-efac-4f03-96a4-525c1892dff2");

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
            yield return new TextBlock { Id = Guid.Parse("8f1607c0-81e6-460c-ae69-ca8ee9b8a3f8"), Type = TextBlockType.Text, Text = "Your touch afflicts the target with goblin pox, an irritating allergenic rash.The target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e80e0812-b7f4-464c-886b-a82c835c842e"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is sickened 1.",
                Failure = "The target is afflicted with goblin pox at stage 1.",
                CriticalFailure = "The target is afflicted with goblin pox at stage 2."
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("f779f7b6-18c3-44d4-ab7e-bc23f0fccc06"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Name = "Goblin Pox",
                MaximumDuration = "1 day.",
                Onset = "Immediate",
                Level = 1,
                Addendum = "Goblins and goblin dogs are immune.",
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("99b74ba3-caf2-4395-bfef-fb7bff6ca246"),
                        Duration = "1 round.",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("718458c7-7439-409d-b70c-d65217b2a116"), ConditionId = Conditions.Instances.Sickened.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("acd2773c-52e1-4603-970c-5a347b933e86"),
                        Duration = "",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("fbc2ac52-cc98-4f69-a968-41fb60649668"), ConditionId = Conditions.Instances.Sickened.ID, Severity = 1},
                            new ConditionEffect { Id = Guid.Parse("2558fe55-adc6-4b09-a3b7-9bb20292e2d2"), ConditionId = Conditions.Instances.Slowed.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("1ddcba26-1d78-4e3b-8a2b-3124a21062e4"),
                        Duration = "",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("7ec94670-2c71-475e-aa3f-a3a31cb7d0df"), ConditionId = Conditions.Instances.Sickened.ID, Severity = 1},
                            new OtherEffect { Id = Guid.Parse("b6374983-4546-4838-9afe-0e2579961111"), Effect = "The creature can't reduce its sickened value below 1."},
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0df7c1f5-8c87-4a0c-91c0-75158f730497"), Traits.Instances.Disease.ID);
            builder.Add(Guid.Parse("85343057-14d2-461e-8820-a2d8d6d2fb4a"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ffe95d2-875c-4626-b6ac-423b26e47fe7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 341
            };
        }
    }
}
