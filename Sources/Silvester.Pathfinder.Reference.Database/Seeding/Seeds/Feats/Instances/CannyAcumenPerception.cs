using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CannyAcumenPerception : Template
    {
        public static readonly Guid ID = Guid.Parse("6c221357-146e-4c1b-9176-a2962dd64f56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Canny Acumen - Perception",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bdcad7f4-e171-4721-ac2f-26a493a196e2"), Type = TextBlockType.Text, Text = "You become an expert in Perception. At 17th level, you become a master instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e009678-a7c4-4cc2-b9d3-b4e345ec0fa1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
