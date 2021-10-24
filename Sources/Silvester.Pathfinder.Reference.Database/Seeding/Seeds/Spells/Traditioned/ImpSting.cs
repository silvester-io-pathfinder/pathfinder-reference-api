using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ImpSting : Template
    {
        public static readonly Guid ID = Guid.Parse("ff6c68a1-e60a-4f3a-8e3d-54c119af4841");

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
            yield return new TextBlock { Id = Guid.Parse("f4c3dfe4-247c-4c6d-8332-3b7adad8dc2e"), Type = TextBlockType.Text, Text = "You reproduce an imp's evil, poisonous sting, stabbing at an enemy and possibly affecting them with the devil's benumbing venom. You deal 1d4 piercing damage to the touched creature and afflict the creature with imp venom. If the target takes piercing damage, they also take 1d6 evil damage and must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6df3c6d2-a4d6-41bc-b096-72159874cc41"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 1d6 poison damage.",
                Failure = "The target is afflicted with imp venom at stage 1.",
                CriticalFailure = "The target is afflicted with imp venom at stage 2."
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("14ec4b16-5301-43a7-8463-4eea0764e06f"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Addendum = "Imp Venom",
                MaximumDuration = "6 rounds.",
                Onset = "Immediate",
                Level = 3,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("2d2932f0-3f49-4a6b-8571-5cca6ad6ba0a"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("f7c815c7-f199-4454-91e7-d87e693480d6"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("eb120f2f-176a-44dd-85ec-9dc969c214f9"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("481e225f-0e0c-4a35-9310-dd44c43eab40"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("3dc58e4d-db84-453b-9169-488b2f1575d8"), Damage = "1d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("df156c72-cfe3-482a-9459-773547e447fb"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1},
                            new ConditionEffect { Id = Guid.Parse("3368dbfe-b377-449e-bfee-8865034f0584"), ConditionId = Conditions.Instances.Slowed.ID, Severity = 1}
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
                Id = Guid.Parse("2cb0dd66-8530-463b-b91f-d7a4282c86fd"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 80
            };
        }
    }
}
