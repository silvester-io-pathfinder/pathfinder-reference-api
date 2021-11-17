using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Track : Template
    {
        public static readonly Guid ID = Guid.Parse("2b57bd40-98aa-4bcc-93b4-8ce2bb830902");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Track",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4753d3ee-ca1a-4c93-97dc-f7c396a5a2c2"), Type = TextBlockType.Text, Text = "You follow tracks, moving at up to half your travel Speed, using the rules on page 479. After a successful check to Track, you can continue following the tracks at half your Speed without attempting additional checks for up to 1 hour. In some cases, you might Track in an encounter. In this case, Track is a single action and doesn�t have the exploration trait, but you might need to roll more often because you�re in a tense situation. The GM determines how often you must attempt this check." };
            yield return new TextBlock { Id = Guid.Parse("da494f42-2237-4aab-b5ff-ff2f9cf02f0f"), Type = TextBlockType.Text, Text = "You attempt your Survival check when you start Tracking, once every hour you continue tracking, and any time something significant changes in the trail. The GM determines the DCs for such checks, depending on the freshness of the trail, the weather, and the type of ground." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Move.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dfb41168-f100-440d-81e3-06afe87b5620"),
                Success = "You find the trail or continue to follow the one you�re already following.",
                Failure = "You lose the trail but can try again after a 1-hour delay.",
                CriticalFailure = "You lose the trail and can�t try again for 24 hours."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("f7e1d86c-5ded-4f54-a4c4-843cf18be232"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "The path of a large army following a road." };
            yield return new SkillActionExample { Id = Guid.Parse("56fa5955-9ad2-47fa-8d60-68c614cb8e13"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Relatively fresh tracks of a rampaging bear through the plains." };
            yield return new SkillActionExample { Id = Guid.Parse("d754bb5b-7cdc-4998-907d-59d18bbca160"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "A nimble panther�s tracks through a jungle, tracks obscured by rainfall." };
            yield return new SkillActionExample { Id = Guid.Parse("77de8ecf-25e8-4606-bf75-7e437715f39c"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Tracks obscured by winter snow, tracks of a mouse or smaller creature, tracks left on surfaces that can�t hold prints like bare rock." };
            yield return new SkillActionExample { Id = Guid.Parse("625636c0-e67d-4a93-8952-6b5c6ebc94a4"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Old tracks through a windy desert�s sands, tracks obscured by a major blizzard or hurricane." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e62c491b-6004-405b-bf57-5cb65de9bfe1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 252
            };
        }
    }
}
