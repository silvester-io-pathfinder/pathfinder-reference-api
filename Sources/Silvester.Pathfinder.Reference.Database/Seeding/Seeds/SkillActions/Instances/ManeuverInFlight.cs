using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class ManeuverInFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("e1960983-7255-48ab-9e0b-2a39b17c5889");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Maneuver in Flight",
                Requirements = "You have a fly speed.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("225643f2-1f2e-4d93-a6ad-d878f3ab5950"), Type = TextBlockType.Text, Text = "You try a difficult maneuver while flying. Attempt an Acrobatics check. The GM determines what maneuvers are possible, but they rarely allow you to move farther than your fly Speed." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Move.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("210ce007-764c-48fe-9984-365c73ed6277"),
                Success = "You succeed at the maneuver.",
                Failure = "Your maneuver fails. The GM chooses if you simply can�t move or if some other detrimental effect happens. The outcome should be appropriate for the maneuver you attempted(for instance, being blown off course if you were trying to fly against a strong wind).",
                CriticalFailure = "As failure, but the consequence is more dire."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("83f8c99f-f1e4-4877-85e5-b6ed590f2011"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Steep ascent or descent." };
            yield return new SkillActionExample { Id = Guid.Parse("7c2340f7-b20b-4ab0-b0f1-32cfba02667d"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Fly against the wind, hover midair." };
            yield return new SkillActionExample { Id = Guid.Parse("fb9ac398-d5d8-4645-92dc-d4ec3c86cf1e"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Reverse direction." };
            yield return new SkillActionExample { Id = Guid.Parse("0e0d4e42-0bed-467b-8595-27d82fa201a6"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Fly through gale force winds." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c758a51f-85d7-4bb0-9058-f798b1743bfe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 240
            };
        }
    }
}
