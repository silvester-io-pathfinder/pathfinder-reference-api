using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DenySupport : Template
    {
        public static readonly Guid ID = Guid.Parse("51daf76b-4a81-41a3-916a-8023f99ea4b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deny Support",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4e73bc3-a0e0-484e-8e2d-9fc8d3ab46e8"), Type = TextBlockType.Text, Text = "~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("8a3a7a20-1553-4060-96c2-a92d179cea05"), Type = TextBlockType.Text, Text = "When you succeed or critically succeed at a Deception check to (action: Feint) an opponent, that target can&#39;t flank with their allies until the beginning of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd31e3f9-fe92-49cb-b046-127b907489ce"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
