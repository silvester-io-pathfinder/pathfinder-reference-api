using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LessonOfLife : Template
    {
        public static readonly Guid ID = Guid.Parse("41b6c9d6-5c4f-47ac-bc90-a6869a2d7362");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lesson of Life",
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
            yield return new TextBlock { Id = Guid.Parse("9a3e1498-0a33-451b-9ad5-33de4ca8084c"), Type = TextBlockType.Text, Text = "~ Lesson Type: Basic" };
            yield return new TextBlock { Id = Guid.Parse("6fce4611-8b6b-4fa8-b519-7296226a5fef"), Type = TextBlockType.Text, Text = "You gain the (spell: life boost) hex, and your familiar learns (spell: spirit link)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22995b3c-75a1-4aeb-ada1-58d07e713867"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
