using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Perform : Template
    {
        public static readonly Guid ID = Guid.Parse("3c27dc70-e674-49cb-bf59-c9a97701f073");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Perform",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("051b3cb9-020f-4941-b28e-ce1acd0342d9"), Type = TextBlockType.Text, Text = "When making a brief performance�one song, a quick dance, or a few jokes�you use the Perform action. This action is most useful when you want to prove your capability or impress someone quickly. Performing rarely has an impact on its own, but it might influence the DCs of subsequent Diplomacy checks against the observers�or even change their attitudes� if the GM sees fit." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Performance.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("eb1add09-c20e-42c0-9b8a-228037c3556b"),
                CriticalSuccess = "Your performance impresses the observers, and they�re likely to share stories of your ability.",
                Success = "You prove yourself, and observers appreciate the quality of your performance.",
                Failure = "Your performance falls flat.",
                CriticalFailure = "You demonstrate only incompetence."
            };
        }
        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("6135161d-ec29-4d4f-94d0-2a5d75724ae9"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Audience of commoners." };
            yield return new SkillActionExample { Id = Guid.Parse("b6719b44-2873-4363-8f5b-fa344c885135"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Audience of artisans." };
            yield return new SkillActionExample { Id = Guid.Parse("957922dd-64cf-4819-b1a5-5724b948c219"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Audience of merchants or minor nobles." };
            yield return new SkillActionExample { Id = Guid.Parse("8bfb118c-52d9-468e-a078-d8177ee9a210"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Audience of high nobility or minor royalty." };
            yield return new SkillActionExample { Id = Guid.Parse("2039bf59-fdb0-4bdf-9e62-4d9fb6309df0"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Audience of major royalty or otherworldly beings." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7af5a513-c68b-4772-a18d-c867dd7a0559"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 250
            };
        }
    }
}
