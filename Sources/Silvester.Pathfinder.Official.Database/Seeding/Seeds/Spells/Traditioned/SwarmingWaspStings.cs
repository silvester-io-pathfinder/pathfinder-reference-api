using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SwarmingWaspStings : Template
    {
        public static readonly Guid ID = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Swarming Wasp Stings",
                Level = 4,
                Range = "30 feet.",
                Area = "10-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"), Type = TextBlockType.Text, Text = "You manifest a swarm of disembodied wasp stingers that stab creatures in the area, possibly poisoning them. Creatures in the affected area take 1d6 piercing damage. Each creature that takes piercing damage must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 2d6 poison damage.",
                Failure = "The target is afflicted with swarming wasp venom at stage 1.",
                CriticalFailure = "The target is afflicted with swarming wasp venom at stage 2."
            };
        }

        protected override StaggeredEffect GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Addendum = "Swarming Wasp Venom",
                MaximumDuration = "6 rounds.",
                Onset = "Immediate",
                Level = 7,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("d51b52ac-6d29-4f8f-85a1-bb650a5831e1"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 2}
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b12473dd-dcf5-4b64-88e3-0fe0715bdcad"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 81
            };
        }
    }
}
