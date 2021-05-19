using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Focusses.Bard.Instances
{
    public class InspireCompetence : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Focus GetFocus()
        {
            return new Focus
            {
                Id = ID,
                Name = "Inspire Competence",
                Level = 1,
                Range = "60 feet.",
                Duration = "1 round.",
                Targets = "1 ally.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Bard.ID,
                FocusTypeId = FocusTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your encouragement inspires your ally to succeed at a task. This counts as having taken sufficient preparatory actions to Aid your ally on a skill check of your choice, regardless of the circumstances. When you later use the Aid reaction, you can roll Performance instead of the normal skill check, and if you roll a failure, you get a success instead. If you are legendary in Performance, you automatically critically succeed." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The GM might rule that you can’t use this ability if the act of encouraging your ally would interfere with the skill check (such as a check to Sneak quietly or maintain a disguise)." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Bard.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Composition.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 386
            };
        }
    }
}
