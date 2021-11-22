using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TortoiseAndTheHare : Template
    {
        public static readonly Guid ID = Guid.Parse("aa07c77a-09a6-417e-8809-699ec411469e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tortoise and the Hare",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 foe, and either yourself or 1 ally.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7df5ad43-b5ba-4f93-8d84-92a362bb5a0d"), Type = TextBlockType.Text, Text = "You prove that slow and steady doesn�t always win the race by turning a foe into a proverbial tortoise and yourself or an ally into a hare, siphoning some of the foe�s speed and granting it to the other target. The effects depend on the foe�s Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6da166b3-d00d-4611-86d9-4184ecc48d09"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The foe is slowed 1 for 1 round, and the other target is unaffected.",
                Failure = "The foe is slowed 1 for 3 rounds and the other target is quickened for 1 round. It can use the extra action to Step, Stride, or Strike.",
                CriticalFailure = "The foe is slowed 1 for 3 minutes and the other target is quickened for 1 minute. It can use the extra action to Step, Stride, or Strike."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9232cc63-f597-408a-b2c0-13e2a0f0c0f9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 137
            };
        }
    }
}
