using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class MakeAnImpression : Template
    {
        public static readonly Guid ID = Guid.Parse("a41c8310-ad27-41a7-8b2a-e667c9be558d");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Make an Impression",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e33a57b9-9597-40c1-8d43-a94dfada9a65"), Type = TextBlockType.Text, Text = "With at least 1 minute of conversation, during which you engage in charismatic overtures, flattery, and other acts of goodwill, you seek to make a good impression on someone to make them temporarily agreeable. At the end of the conversation, attempt a Diplomacy check against the Will DC of one target, modified by any circumstances the GM sees fit. Good impressions (or bad impressions, on a critical failure) last for only the current social interaction unless the GM decides otherwise." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("9b6c6414-1dee-4bb6-bb13-c0eab9fca631"),
                CriticalSuccess = "The target�s attitude toward you improves by two steps.",
                Success = "The target�s attitude toward you improves by one step.",
                CriticalFailure = "The target�s attitude toward you decreases by one step."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2578212-7cea-40aa-bffb-f6b6e78e964b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 246
            };
        }
    }
}
