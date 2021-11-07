using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarrenDigger : Template
    {
        public static readonly Guid ID = Guid.Parse("fe580bbd-149a-4db4-affe-6e73a522e6ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warren Digger",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54f73a78-6f32-4ab6-9181-0c5a0d8f375b"), Type = TextBlockType.Text, Text = "You&#39;ve learned to put your sturdy claws to work digging through the earth. You gain a burrow Speed of 15 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61454916-8eb5-4442-9d18-9742aa13f24b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
