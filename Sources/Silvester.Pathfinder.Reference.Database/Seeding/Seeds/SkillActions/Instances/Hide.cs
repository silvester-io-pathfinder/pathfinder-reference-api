using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Hide : Template
    {
        public static readonly Guid ID = Guid.Parse("f58155c8-c78c-4ab1-999c-9bfa15ac3456");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Hide",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("166c1150-df30-43e1-9bf3-c0cf37d30d20"), Type = TextBlockType.Text, Text = "You huddle behind cover or greater cover or deeper into concealment to become hidden, rather than observed. The GM rolls your Stealth check in secret and compares the result to the Perception DC of each creature you�re observed by but that you have cover or greater cover against or are concealed from. You gain the circumstance bonus from cover or greater cover to your check." };
            yield return new TextBlock { Id = Guid.Parse("04304c01-519f-4cc1-9a6c-c8ac71b0d0c5"), Type = TextBlockType.Text, Text = "If you successfully become hidden to a creature but then cease to have cover or greater cover against it or be concealed from it, you become observed again. You cease being hidden if you do anything except Hide, Sneak, or Step." };
            yield return new TextBlock { Id = Guid.Parse("258007fa-ba0f-4bcb-bcdf-df45a45221fe"), Type = TextBlockType.Text, Text = "If you attempt to Strike a creature, the creature remains flatfooted against that attack, and you then become observed. If you do anything else, you become observed just before you act unless the GM determines otherwise. The GM might allow you to perform a particularly unobtrusive action without being noticed, possibly requiring another Stealth check." };
            yield return new TextBlock { Id = Guid.Parse("120dc281-758d-4c70-99e3-9d0c0070dc46"), Type = TextBlockType.Text, Text = "If a creature uses Seek to make you observed by it, you must successfully Hide to become hidden from it again." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("c81313c7-b64a-4514-8a64-a0a3fbb13954"),
                Success = "If the creature could see you, you�re now hidden from it instead of observed. If you were hidden from or undetected by the creature, you retain that condition.",
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0c0b8e4-37f5-482c-a3ba-6b14d8e9e9e1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 251
            };
        }
    }
}
