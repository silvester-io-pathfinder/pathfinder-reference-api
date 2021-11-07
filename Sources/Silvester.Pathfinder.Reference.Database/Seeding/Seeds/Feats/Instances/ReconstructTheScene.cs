using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReconstructTheScene : Template
    {
        public static readonly Guid ID = Guid.Parse("c9b1fd63-955c-4175-9fbb-8722aa1117d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reconstruct the Scene",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("afbe76ad-73fb-4164-81d9-50cdcc2b6e43"), Type = TextBlockType.Text, Text = "You spend 1 minute surveying a small location (such as a single room) to get an impression of events that occurred there in the last day. This involves moving about the area and studying footprints, the placement of objects, spilled drinks or blood, and so forth. You get an indistinct mental impression of significant events that happened there. This gives you clues and details of the past, including the overall events and their time frame, but it’s not a perfect record. This also isn’t enough to identify who was involved in these events if you weren’t already aware the person was there. As determined by the GM, you also pick out various seemingly small details that could serve as important clues, like a memorable weapon someone used for a murder or the type of cloak someone wore when passing through." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ed5f3d9-4e92-4e67-b991-4db58e827f81"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
