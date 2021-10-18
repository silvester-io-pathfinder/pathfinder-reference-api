using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class SkillTrainingFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("b5a95cad-67ab-4716-b582-4a11d8b863d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                CanBeLearnedMoreThanOnce = true,
                Name = "Skill Training",
                Level = 1,
                Special = "You can select this feat multiple times, choosing a new skill to become trained in each time.",
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0edf9962-598d-4813-bdef-f310458b9ea6"), Type = Utilities.Text.TextBlockType.Text, Text = "You become trained in the skill of your choice." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificStatPrerequisite { Id = Guid.Parse("ab0d488c-fa87-4289-93f6-91df2166f822"), RequiredStatId = Stats.Instances.Intelligence.ID, RequiredStatValue = 12 };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7256f316-1dd3-406c-ac5b-b242a9e9a215"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 266
            };
        }
    }
}
