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

        protected override IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield return new StaggeredEffect
            {
                Id = Guid.Parse("944ef13d-d697-4668-8f93-38bce9f3ec2f"),
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
                            new DamageEffect {Id = Guid.Parse("e7ea3b60-2e63-4150-9ef6-72210d8461d6"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("34a42642-8915-48fb-bfb4-8172208788f3"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("1 round"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("dd94d5d1-168f-4268-a3f2-90f41ef21bf3"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("daf0165d-0334-4f8b-abde-a7129b224564"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1},
                            new ConditionEffect { Id = Guid.Parse("85ca009e-e486-481e-b7da-3e53456cb1cc"), ConditionId = Conditions.Instances.Slowed.ID, Severity = 1}
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
