using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class GatherInformation : Template
    {
        public static readonly Guid ID = Guid.Parse("3cb5aa6e-958a-4043-bcc6-1f016ebf270c");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Gather Information",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9c2025ae-0b20-42c8-a8a1-2b60f672a673"), Type = TextBlockType.Text, Text = "You canvass local markets, taverns, and gathering places in an attempt to learn about a specific individual or topic. The GM determines the DC of the check and the amount of time it takes (typically 2 hours, but sometimes more), along with any benefit you might be able to gain by spending coin on bribes, drinks, or gifts." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Diplomacy.ID;
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
                Id = Guid.Parse("850c97ce-cc5d-4468-8e9c-d91125d37c82"),
                Success = "You collect information about the individual or topic. The GM determines the specifics.",
                CriticalFailure = "You collect incorrect information about the individual or topic."
            };
        }

        protected override IEnumerable<SkillActionExample> GetExamples()
        {
            yield return new SkillActionExample { Id = Guid.Parse("86a839dc-3ab6-40f4-9750-8b2f6b6170ed"), ProficiencyId = Proficiencies.Instances.Untrained.ID, Description = "Talk of the town." };
            yield return new SkillActionExample { Id = Guid.Parse("1b6e8ae3-12e3-46d1-b004-cf096f6b607d"), ProficiencyId = Proficiencies.Instances.Trained.ID, Description = "Common rumor." };
            yield return new SkillActionExample { Id = Guid.Parse("2cc694f2-079d-44cd-b181-75c73a97a014"), ProficiencyId = Proficiencies.Instances.Expert.ID, Description = "Obscure rumor, poorly guarded secret." };
            yield return new SkillActionExample { Id = Guid.Parse("080db285-0bac-41d6-a772-3d4a943a59ae"), ProficiencyId = Proficiencies.Instances.Master.ID, Description = "Well-guarded or esoteric information." };
            yield return new SkillActionExample { Id = Guid.Parse("e6146614-c6a2-4734-865c-148bc895d3ec"), ProficiencyId = Proficiencies.Instances.Legendary.ID, Description = "Information known only to an incredibly select few, or only to extraordinary beings." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f5344e7-39fd-445e-8780-86e6df7ee587"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 246
            };
        }
    }
}
