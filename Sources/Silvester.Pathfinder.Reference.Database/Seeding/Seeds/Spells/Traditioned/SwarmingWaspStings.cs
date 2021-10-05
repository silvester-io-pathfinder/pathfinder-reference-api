using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SwarmingWaspStings : Template
    {
        public static readonly Guid ID = Guid.Parse("8aa7ba58-13b1-4589-8d66-0e88a6083e7d");

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
            yield return new TextBlock { Id = Guid.Parse("d8ce44f4-d0b5-4a05-9711-c53580128385"), Type = TextBlockType.Text, Text = "You manifest a swarm of disembodied wasp stingers that stab creatures in the area, possibly poisoning them. Creatures in the affected area take 1d6 piercing damage. Each creature that takes piercing damage must attempt a Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("48633973-efa3-405e-b4e3-7a049c8bf683"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 2d6 poison damage.",
                Failure = "The target is afflicted with swarming wasp venom at stage 1.",
                CriticalFailure = "The target is afflicted with swarming wasp venom at stage 2."
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("f059013b-f12f-412c-a417-d00691ba4331"),
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                Addendum = "Swarming Wasp Venom",
                MaximumDuration = "6 rounds.",
                Onset = "Immediate",
                Level = 7,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("0fc25e89-c73f-4d04-b348-ada34efb721b"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("a9f8cd05-531c-47ab-8c96-12e0860207b5"), Damage = "2d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("b351caf1-e0d6-435b-b3ce-bfdcd702bb48"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("d51b52ac-6d29-4f8f-85a1-bb650a5831e1"),
                        Duration = "1 round",
                        Effects =
                        {
                            new DamageEffect {Id = Guid.Parse("fa015f93-1392-4694-81e8-8f85e31dc8fe"), Damage = "3d6", DamageTypeId = DamageTypes.Instances.Poison.ID },
                            new ConditionEffect { Id = Guid.Parse("865b5607-f687-4fa5-8ef4-6fc77b68dbd9"), ConditionId = Conditions.Instances.Clumsy.ID, Severity = 2}
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
                Id = Guid.Parse("662b2eca-e161-49de-850c-4abe0e92a835"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 81
            };
        }
    }
}
