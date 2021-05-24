using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ImpSting : Template
    {
        public static readonly Guid ID = Guid.Parse("e04bba9b-6fb7-41cb-807d-6aca9a2ee809");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Imp Sting",
                Level = 2,
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("55e11098-b226-4b3f-bca8-98347abedc55"), Type = TextBlockType.Text, Text = "You reproduce an imp's evil, poisonous sting, stabbing at an enemy and possibly affecting them with the devil's benumbing venom. You deal 1d4 piercing damage to the touched creature and afflict the creature with imp venom. If the target takes piercing damage, they also take 1d6 evil damage and must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c02cdb57-7742-41c9-ac0c-0255a05cb648"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 1d6 poison damage.",
                Failure = "The target is afflicted with imp venom at stage 1.",
                CriticalFailure = "The target is afflicted with imp venom at stage 2."
            };
        }

        protected override StaggeredEffect GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("c370de1b-c838-4bca-aab9-c24b530ba7e4"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Addendum = "Imp Venom",
                MaximumDuration = "6 rounds.",
                Onset = "Immediate",
                Level = 3,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("d3412211-fdd9-45ee-bff2-c686d8bbe9d2"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("9e85f973-c608-4b93-89a8-54424255da39"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("d6a7fe02-7e5e-4279-91fb-c23e1b54bc67"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("017f1b06-7ead-4e16-a118-ba4b84bcf862"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("00290af8-3e00-465e-9fba-e02f8553f4a8"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("d8b611a7-545d-4f21-91b2-c7b903540909"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1},
                            new ConditionEffect { Id = Guid.Parse("412892fa-1b01-491c-887e-74e8f995f77a"), ConditionId = Conditions.Instances.Slowed.ID, Severity = 1}
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("611512e7-f3f5-42cf-8c40-69036e24ef23"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 80
            };
        }
    }
}
