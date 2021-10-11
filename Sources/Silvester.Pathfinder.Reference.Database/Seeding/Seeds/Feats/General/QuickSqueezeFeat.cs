using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class QuickSqueezeFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8a71ca0e-0c73-4fdd-bde7-431f3237bca6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Squeeze",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("605cae2e-9971-44ec-9fe2-9df99dd6fa87"), Type = Utilities.Text.TextBlockType.Text, Text = "You Squeeze 5 feet per round (10 feet on a critical success). If you’re legendary in Acrobatics, you Squeeze at full Speed." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("ba0d0a02-d876-441f-9226-f270c0ed0fab"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
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
                Id = Guid.Parse("7433039d-4138-437a-87dc-384b365e1271"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 265
            };
        }
    }
}
