using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Cleric.Instances
{
    public class CharmingTouch : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Charming Touch",
                Level = 1,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature that could find you attractive.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                DomainId = Domains.Instances.Passion.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                FocusTypeId = FocusTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You infuse your target with attraction, causing it to act friendlier toward you. The target attempts a Will save. It gains a +4 circumstance bonus to this save if you or your allies recently threatened or were hostile to it." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can Dismiss the spell. If you use hostile actions against the target, the spell ends. After the spell ends, the target doesn’t necessarily realize it was charmed unless its friendship with you or the actions you convinced it to take clash with its expectations, which could potentially allow you to convince the target to continue being your friend via mundane means." };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
                CriticalSuccess = "The target is unaffected and aware you tried to charm it.",
                Success = "The target is unaffected but thinks your spell was something harmless instead of charming touch, unless it identifies the spell (see Identifying Spells on page 305).",
                Failure = "The target’s attitude becomes friendly toward you. If it was friendly, it becomes helpful. It can’t use hostile actions against you.",
                CriticalFailure = "The target is helpful and can’t use hostile actions against you."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 390
            };
        }
    }
}
