using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Banishment : Template
    {
        public static readonly Guid ID = Guid.Parse("3a8c5edf-e86c-431a-a25a-bb90d590eb35");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Banishment",
                Level = 5,
                Range = "30 feet.",
                Targets = "1 creature that isn't on its home plane.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d451add9-b4c2-45ea-84f3-b54202846d17"), Type = Utilities.Text.TextBlockType.Text, Text = "You send the target back to its home plane. The target must attempt a Will save. You can spend an extra action while Casting this Spell and add a material component to give the creature a –2 circumstance penalty to its save. The component must be a specially gathered object that is anathema to the creature, and not from a material component pouch. This spell fails if you aren’t on your home plane when you cast it." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("dd05b759-b382-42f9-bfef-e8600b2b28f9"),
                CriticalSuccess = "The target resists being banished and you are stunned 1.",
                Success = "The target resists being banished.",
                Failure = "The target is banished.",
                CriticalFailure = "The target is banished and can’t return by any means to the plane it’s banished from for 1 week."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("62d6f3f0-5ae7-4ceb-b943-d716a9d05586"),
                Level = "9th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d8510f7f-7901-415d-970e-68f0949a82b7"), Type = Utilities.Text.TextBlockType.Text, Text = "You can target up to 10 creatures. The extra material component affects targets to which it is anathema." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Incapacitation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b76c19f9-27ee-4e77-80c7-64e8fe0c5ac2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 320
            };
        }
    }
}
