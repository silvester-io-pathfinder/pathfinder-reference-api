using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class InspireHeroics : Template
    {
        public static readonly Guid ID = Guid.Parse("d6c30411-708d-4f50-ad18-ff30380f2138");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inspire Heroics",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7ed9b86-460a-4d22-9821-2e3b3631eb71"), Type = TextBlockType.Text, Text = "You call upon your muse to greatly increase the benefits you provide with your inspire courage or inspire defense composition. If your next action is to cast inspire courage or inspire defense, attempt a Performance check. The DC is usually a very hard DC of a level equal to that of the highest-level target of your composition, but the GM can assign a different DC based on the circumstances. The effect of your inspire courage or inspire defense composition depends on the result of your check." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e31f9efe-e0aa-4e78-835d-8d0b1b558410"),
                CriticalSuccess = "The status bonus from your inspire courage or inspire defense increases to +3.",
                Success = "The status bonus from inspire courage or inspire defense increases to +2.",
                Failure = "Your inspire courage or inspire defense provides only its normal bonus of +1, but you don’t spend the Focus Point for casting this spell.",
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
                Id = Guid.Parse("d8f7b332-ffd7-4f84-9e45-66434bfb8805"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 387
            };
        }
    }
}
