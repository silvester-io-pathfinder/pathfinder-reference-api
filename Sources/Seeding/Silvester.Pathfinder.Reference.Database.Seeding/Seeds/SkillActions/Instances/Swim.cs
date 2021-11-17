using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Swim : Template
    {
        public static readonly Guid ID = Guid.Parse("b367e19f-66e6-4773-9ac6-612045e8580c");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Swim",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("63883c26-a9e1-4fb8-b8ea-56f86d6df0bd"), Type = TextBlockType.Text, Text = "You propel yourself through water. In most calm water, you succeed at the action without needing to attempt a check. If you must breathe air and you�re submerged in water, you must hold your breath each round. If you fail to hold your breath, you begin to drown (as described on page 478). If the water you are swimming in is turbulent or otherwise dangerous, you might have to attempt an Athletics check to Swim." };
            yield return new TextBlock { Id = Guid.Parse("1d298d75-50af-4408-8ee5-356914211dab"), Type = TextBlockType.Text, Text = "If you end your turn in water and haven�t succeeded at a Swim action that turn, you sink 10 feet or get moved by the current, as determined by the GM. However, if your last action on your turn was to enter the water, you don�t sink or move with the current that turn." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Athletics.ID;
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
                Id = Guid.Parse("5cf534b3-efdb-4ae2-b9bd-261d35daae54"),
                CriticalSuccess = "You move through the water 10 feet, plus 5 feet per 20 feet of your land Speed(a total of 15 feet for most PCs).",
                Success = "You move through the water 5 feet, plus 5 feet per 20 feet of your land Speed (a total of 10 feet for most PCs).",
                CriticalFailure = "You make no progress, and if you�re holding your breath, you lose 1 round of air."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("9d0d5f47-911d-455a-804f-aa18250d6cab"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Lake or other still water." };
            yield return new SkillActionExample { Id = Guid.Parse("d828ef31-7179-4c02-b29e-6e2b8518d797"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Flowing water, like a river." };
            yield return new SkillActionExample { Id = Guid.Parse("21bff63d-1c11-496b-a6ae-2a4b3efd4ca0"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Swiftly flowing river." };
            yield return new SkillActionExample { Id = Guid.Parse("39ab9061-32c2-4f5e-96ae-691c84e95ae3"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Stormy sea." };
            yield return new SkillActionExample { Id = Guid.Parse("ede1e3d2-db11-45c0-968a-9636249dc5cc"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Maelstrom, waterfall." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c26cd01-9004-4db3-bfb8-310b06fbc966"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 243
            };
        }
    }
}
