using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiderSting : Template
    {
        public static readonly Guid ID = Guid.Parse("a8a90053-90d2-4969-a70f-4724b37f7a57");

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
            yield return new TextBlock { Id = Guid.Parse("29ad5637-e0d6-42fe-80ca-9847989751b9"), Type = TextBlockType.Text, Text = "You magically duplicate a spider’s venomous sting. You deal 1d4 piercing damage to the touched creature and afflict it with spider venom. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("b9fec79c-a369-47e6-8dca-2935a1ecba9c"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 1d4 poison damage.",
                Failure = "The target is afflicted with spider venom at stage 1.",
                CriticalFailure = "The target is afflicted with spider venom at stage 2."
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("a1cfde24-4be9-4103-8a78-67f6ab1677e7"),
                Addendum = "Spider Venom",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "4 rounds.",
                Onset = "Immediate",
                Level = 1,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("eddd7fe5-3fa5-4462-a193-cc33914a9b42"),
                        Duration = "1 round.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("05ccee10-8ffd-4880-9ada-ab0e9c2587d8"), Damage = "1d4", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("a4bdc31a-f93f-4c6e-bbd0-d9a8c84f4b5a"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("d566e2ff-1134-475d-b4f8-a7a3724c29d2"),
                        Duration = "1 round.",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("4794da87-488c-4282-b07c-f92bedc4300a"), Damage = "1d4", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("e53047c7-b2c6-49d3-ab62-efa783987154"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 2}
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
                Id = Guid.Parse("486313b7-ee69-427f-85cc-13e060de6e11"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 371
            };
        }
    }
}
