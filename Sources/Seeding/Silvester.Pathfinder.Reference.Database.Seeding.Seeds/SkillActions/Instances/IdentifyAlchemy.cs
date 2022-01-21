using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class IdentifyAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("4dfe5320-b9f6-43a4-b36e-30584ef9f5ff");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Identify Alchemy",
                Requirements = "You are holding or wearing alchemist�s tools (page 287).",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("387f9bd5-037d-4b7d-bd93-4a619132129d"), Type = TextBlockType.Text, Text = "You can identify the nature of an alchemical item with 10 minutes of testing using alchemist�s tools. If your attempt is interrupted in any way, you must start over." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("312d7e2f-0fdd-4a53-9b00-0523bdbc9d79"),
                Success = "You identify the item and the means of activating it.",
                Failure = "You fail to identify the item but can try again.",
                CriticalFailure = "You misidentify the item as another item of the GM�s choice."
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
                Id = Guid.Parse("589c14d5-5397-46c5-81a0-fd541d2aa476"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 245
            };
        }
    }
}
