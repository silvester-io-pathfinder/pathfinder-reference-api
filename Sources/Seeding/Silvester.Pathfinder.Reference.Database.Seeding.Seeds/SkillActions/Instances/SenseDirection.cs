using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class SenseDirection : Template
    {
        public static readonly Guid ID = Guid.Parse("10ffdf84-7b61-43e5-a3a5-b95f22e77a6d");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Sense Direction",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7194d69b-48bc-4326-adcf-f485adba3a63"), Type = TextBlockType.Text, Text = "Using the stars, the position of the sun, traits of the geography or flora, or the behavior of fauna, you can stay oriented in the wild. Typically, you attempt a Survival check only once per day, but some environments or changes might necessitate rolling more often. The GM determines the DC and how long this activity takes (usually just a minute or so). More unusual locales or those you're unfamiliar with might require you to have a minimum proficiency rank to Sense Direction. Without a compass, you take a -2 item penalty to checks to Sense Direction." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("15a35a4e-f790-428f-9238-f6a5e718e1d4"),
                CriticalSuccess = "You get an excellent sense of where you are. If you are in an environment with cardinal directions, you know them exactly.",
                Success = "You gain enough orientation to avoid becoming hopelessly lost. If you are in an environment with cardinal directions, you have a sense of those directions.",
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("05e0dee6-0fb7-4527-a7d3-aff177c31892"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Determine a cardinal direction using the sun." };
            yield return new SkillActionExample { Id = Guid.Parse("0abcefb3-983c-446d-97d6-140f75c3b13b"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Find an overgrown path in a forest." };
            yield return new SkillActionExample { Id = Guid.Parse("cb7ccd9c-202e-4f76-af8f-44f69d58caf3"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Navigate a hedge maze." };
            yield return new SkillActionExample { Id = Guid.Parse("f56e5ca6-0b83-4157-aa95-c89dd0bd1587"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Navigate a byzantine labyrinth or relatively featureless desert." };
            yield return new SkillActionExample { Id = Guid.Parse("9b5257e1-bed9-42b8-9832-8ecfab7f8912"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Navigate an ever-changing dream realm." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4d875ae-8bcb-452e-a99c-6a895939643d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 252
            };
        }
    }
}
