using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Confusion : Template
    {
        public static readonly Guid ID = Guid.Parse("068fc3bd-e1ac-4069-8a29-13bd1a0b92f2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Confusion",
                Level = 4,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d9ca856-2b8d-40b2-acd8-de53e723931d"), Type = Utilities.Text.TextBlockType.Text, Text = "You befuddle your target with strange impulses, causing it to act randomly. The effects are determined by the target’s Will save. You can Dismiss the spell." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c52f431c-b8b3-4c0b-946d-1491a8e5168f"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target babbles incoherently and is stunned 1.",
                Failure = "The target is confused for 1 minute. It can attempt a new save at the end of each of its turns to end the confusion.",
                CriticalFailure = "The target is confused for 1 minute, with no save to end early."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("283ef60d-8ca4-463d-80cc-12bafa287dfc"),
                Level = "8th", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6af0fd96-e785-48b6-928d-9836e6e0025c"), Type = Utilities.Text.TextBlockType.Text, Text = "You can target up to 10 creatures." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b08badf9-d75a-4306-8c81-98a4e7c5b07f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 325
            };
        }
    }
}
