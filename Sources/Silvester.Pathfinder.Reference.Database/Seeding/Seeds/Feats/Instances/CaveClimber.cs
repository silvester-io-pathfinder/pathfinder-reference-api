using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CaveClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("258dfe74-9e0b-41df-8a2d-40bb3bc6ec98");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cave Climber",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7db86eb-0c95-4489-bc31-95d26ebf49d9"), Type = TextBlockType.Text, Text = "After years of crawling and climbing through caverns, you can climb easily anywhere you go. You gain a climb Speed of 10 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e25ca799-965c-4626-858d-be7cc7b5bb13"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
