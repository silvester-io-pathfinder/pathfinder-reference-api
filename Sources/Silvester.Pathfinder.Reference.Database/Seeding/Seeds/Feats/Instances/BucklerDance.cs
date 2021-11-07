using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BucklerDance : Template
    {
        public static readonly Guid ID = Guid.Parse("f5edd3ea-6d0e-4d15-89a0-5380ebdd8bc0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Buckler Dance",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad23ace1-76de-4d22-90b6-c19273805daa"), Type = TextBlockType.Text, Text = "You spin your buckler defensively toward every attack. While you are in this stance, you constantly have your (item: buckler) raised as if you’d used (action: Raise a Shield), as long as you meet that action’s requirements." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e2b15cd-1d4d-4016-bc38-f0a1bf81baa9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
