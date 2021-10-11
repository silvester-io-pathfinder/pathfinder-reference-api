using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class KipUpFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("4f6b0041-df64-4d81-9ddd-baebcfdd28ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kip Up",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0ff07c3-5e1e-4258-8e85-c1255b47705e"), Type = Utilities.Text.TextBlockType.Text, Text = "You stand up. This movement doesn’t trigger reactions." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("76fe7bde-7fb7-4ddf-86c5-02e226fe18fa"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
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
                Id = Guid.Parse("865dc6fc-7a34-49f5-a065-7d309b6d9527"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 262
            };
        }
    }
}
