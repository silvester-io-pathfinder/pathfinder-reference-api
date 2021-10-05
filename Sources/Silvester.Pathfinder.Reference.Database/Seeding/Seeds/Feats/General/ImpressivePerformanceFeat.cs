using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class ImpressivePerformanceFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("6f87700e-7194-47d6-a9b2-20e0e2e53482");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impressive Performance",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("180ac1bb-e6ae-4d53-b33a-71978026a8e5"), Type = Utilities.Text.TextBlockType.Text, Text = "Your performances inspire admiration and win you fans. You can Make an Impression using Performance instead of Diplomacy." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ca730a60-9507-4f6a-8279-33e15fe8d7eb"), RequiredSkillId = Skills.Instances.Performance.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
