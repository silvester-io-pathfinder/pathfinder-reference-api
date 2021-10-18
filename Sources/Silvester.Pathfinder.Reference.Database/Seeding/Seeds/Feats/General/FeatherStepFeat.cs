using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class FeatherStepFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("174c21f8-b29a-4141-9070-eca5ecfdee71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feather Step",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a59de26-a216-4f4f-b81f-094eb8998249"), Type = Utilities.Text.TextBlockType.Text, Text = "You step carefully and quickly. You can Step into difficult terrain." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new HaveSpecificStatPrerequisite { Id = Guid.Parse("276c32c0-d4b4-468b-bd7d-3faa635a76b6"), RequiredStatValue = 14, RequiredStatId = Stats.Instances.Dexterity.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b756fe7-4108-42cc-a62c-73ab80e7f353"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 261
            };
        }
    }
}
