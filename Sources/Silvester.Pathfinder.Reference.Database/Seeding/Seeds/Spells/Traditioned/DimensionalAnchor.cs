using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionalAnchor : Template
    {
        public static readonly Guid ID = Guid.Parse("c1546cbd-ec60-459f-b7f5-e29d51beb5f2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dimensional Anchor",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature",
                Duration = "Varies.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e47d375a-7490-4544-81be-809b2bd3cbf8"), Type = Utilities.Text.TextBlockType.Text, Text = "You interfere with the target’s ability to teleport and travel between dimensions. Dimensional anchor attempts to counteract any teleportation effect, or any effect that would move the target to a different plane. The duration is determined by the target’s Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect 
            {
                Id = Guid.Parse("7a397e05-ef94-4531-a4d8-24e4596d37c7"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The effect’s duration is 1 minute.",
                Failure = "The effect’s duration is 10 minutes.", 
                CriticalFailure = "The effect’s duration is 1 hour."
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b7380a5-6851-4eab-9ac2-b7a8ff74b280"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 329
            };
        }
    }
}
