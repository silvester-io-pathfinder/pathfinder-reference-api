using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PurpleWormSting : Template
    {
        public static readonly Guid ID = Guid.Parse("c4507279-ec9c-4506-8f37-94e94744dbda");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Purple Worm Sting",
                Level = 6,
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
            yield return new TextBlock { Id = Guid.Parse("34280ebf-7a8a-4cda-b7c3-92d65f0e901c"), Type = TextBlockType.Text, Text = "You replicate the attack of a deadly purple worm. You deal 3d6 piercing damage to the touched creature and afflict it with purple worm venom. The target must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ef911985-73d9-4a11-930f-5d96e5cfc265"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 3d6 poison damage.",
                Failure = "The target is afflicted with purple worm venom at stage 1.",
                CriticalFailure = "The target is afflicted with purple worm venom at stage 2."
            };
        }

        protected override IEnumerable<StaggeredEffect> GetStaggeredEffects()
        {
            yield return new StaggeredEffect
            {
                Id = Guid.Parse("8596230a-69b3-4bea-9053-51d6afb4b3a9"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Addendum = "Purple Worm Venom",
                MaximumDuration = "6 rounds.",
                Onset = "Immediate",
                Level = 11,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("22a5b2f6-3c82-450e-951f-526fb3d21047"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("e1bb5ec0-c96d-4db5-bd74-f601f35d5a72"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("4d220d42-0bc6-457b-956c-f6f8af27af90"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("b49519ed-693c-43fa-b60a-c123f196c63d"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("79f0070c-def8-490d-a65f-6c5148701b2e"), Damage = "4d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("d1d06afb-4a52-4cb1-96c5-80324a0b1e74"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 2}
                        }
                    }, 
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("94df07dd-0a7e-467f-a056-32bc9e9f0f62"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("5e6ca025-ea08-4d38-a593-f4c935e14498"), Damage = "6d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("f92784f9-b299-45fb-a8df-99ed81c60611"), ConditionId = Conditions.Instances.Enfeebled.ID, Severity = 2}
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
                Id = Guid.Parse("96cd1bea-cad4-4b3d-85c0-4930a1362ffb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
