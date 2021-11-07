using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivinerSense : Template
    {
        public static readonly Guid ID = Guid.Parse("bb6cc394-e9f2-4571-b87e-9be8e75bcabb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diviner Sense",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa0a7705-e901-4c68-bf77-3cbacb40abd6"), Type = TextBlockType.Text, Text = "You sense magical dangers. When using the (activity: Detect Magic) exploration activity, you can roll initiative twice and use the better result so long as at least one opponent has a (trait: magical) effect or magic item and is in range of your (spell: detect magic)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c44dee08-bfe5-4c94-a4f7-2193ac03f307"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
