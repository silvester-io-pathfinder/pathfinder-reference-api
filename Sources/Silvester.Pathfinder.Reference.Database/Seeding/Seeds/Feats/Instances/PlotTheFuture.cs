using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlotTheFuture : Template
    {
        public static readonly Guid ID = Guid.Parse("547cc2e7-c5cc-4baa-9008-ac59f0e905af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plot the Future",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("084ff716-27b9-4e42-bc33-6f9ef2004719"), Type = TextBlockType.Text, Text = "You spend 10 minutes in contemplation to uncannily predict how events will play out. Choose a particular goal or activity you plan to engage in within 1 week, or an event you expect might happen within 1 week. You analyze whether it&#39;s likely to come to pass, learning whether it&#39;s highly likely, somewhat likely, somewhat unlikely, or highly unlikely. You also gain a piece of advice suggesting a course of action you or your allies could take that might make the chosen event more or less likely, whichever you prefer. The GM determines the likeliness of the event and the piece of advice you learn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fee534a7-769d-49a9-af12-cfd81451558b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
