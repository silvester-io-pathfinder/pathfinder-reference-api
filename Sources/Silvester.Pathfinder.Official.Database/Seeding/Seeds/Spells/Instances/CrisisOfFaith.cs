using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CrisisOfFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("b7157338-c1de-4e79-a90c-e0f62abd709c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Crisis of Faith",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06dc06f4-c454-423d-9791-25b2e2fb90e3"), Type = Utilities.Text.TextBlockType.Text, Text = "You assault the target’s faith, riddling the creature with doubt and mental turmoil that deal 6d6 mental damage, or 6d8 mental damage if it can cast divine spells. The effects are determined by its Will save." };
            yield return new TextBlock { Id = Guid.Parse("858468ee-88f6-495c-8cf5-542d9209b061"), Type = Utilities.Text.TextBlockType.Text, Text = "To many deities, casting this spell on a follower of your own deity without significant cause is anathema." }; 
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6a073760-7f3c-41ea-adbc-276607b88ece"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half damage.",
                Failure = "The target takes full damage; if the target can cast divine spells, it’s stupefied 1 for 1 round.",
                CriticalFailure = "The target takes double damage, is stupefied 1 for 1 round, and can’t cast divine spells for 1 round."
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ae249d83-3fe3-4e38-8154-4d6b07924f3c"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("654e55bf-4a75-436b-a793-20451384ad00"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 2d6 (or by 2d8 if the target is a divine spellcaster)." }
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 326
            };
        }
    }
}
