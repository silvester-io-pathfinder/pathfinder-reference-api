using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class LingeringComposition : Template
    {
        public static readonly Guid ID = 0e4908a4-698a-4010-8598-333efc7d6acd);

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Lingering Composition",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42799097-6345-4966-94b6-ef51622b4a20"), Type = TextBlockType.Text, Text = "You add a flourish to your composition to extend its benefits. If your next action is to cast a cantrip composition with a duration of 1 round, attempt a Performance check. The DC is usually a standard-difficulty DC of a level equal to the highest-level target of your composition, but the GM can assign a different DC based on the circumstances. The effect depends on the result of your check." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("66178f73-c84d-45fe-8d92-60e9b9b440e5"),
                CriticalSuccess = "The composition lasts 4 rounds.",
                Success = "The composition lasts 3 rounds.",
                Failure = "The composition lasts 1 round, but you don’t spend the Focus Point for casting this spell.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ee15ac8-bdb6-4558-a2d8-05b6e120b7bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
