using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class ForceOpen : Template
    {
        public static readonly Guid ID = Guid.Parse("d23a3e95-8d82-4d7b-bc0e-f93872885f8d");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Force Open",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ee410efe-5aea-486a-8b49-e7bece3e17bb"), Type = TextBlockType.Text, Text = "Using your body, a lever, or some other tool, you attempt to forcefully open a door, window, container or heavy gate. With a high enough result, you can even smash through walls. Without a crowbar, prying something open takes a �2 item penalty to the Athletics check to Force Open." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("2fe9973c-1e92-490d-a053-ed0e47d3d920"),
                CriticalSuccess = "You open the door, window, container, or gate and can avoid damaging it in the process.",
                Success = "You break the door, window, container, or gate open, and it gains the broken condition. If it�s especially sturdy, the GM might have it take damage but not be broken.",
                Failure = "",
                CriticalFailure = "Your attempt jams the door, window, container, or gate shut, imposing a �2 circumstance penalty on future attempts to Force it Open."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("1807fbd7-4711-4193-b0cb-82bfa85269de"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Fabric, flimsy glass." };
            yield return new SkillActionExample { Id = Guid.Parse("088da4dd-a5c6-41e1-8b8a-ab52bd8e2fa0"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Ice, sturdy glass." };
            yield return new SkillActionExample { Id = Guid.Parse("80948d7c-4318-40c9-b7e4-969075e433d7"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Flimsy wooden door, wooden portcullis." };
            yield return new SkillActionExample { Id = Guid.Parse("4fc617f9-74d5-4b7f-94cd-bf7ee7d468cc"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Sturdy wooden door, iron portcullis, metal bar." };
            yield return new SkillActionExample { Id = Guid.Parse("2451ef76-735b-4820-8c8b-38d969ff2be5"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Stone or iron door." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53e3c090-5fa3-4986-8fb2-f044ce554b2c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 242
            };
        }
    }
}
