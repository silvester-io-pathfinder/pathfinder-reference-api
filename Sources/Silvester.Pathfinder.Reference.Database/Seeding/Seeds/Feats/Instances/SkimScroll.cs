using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkimScroll : Template
    {
        public static readonly Guid ID = Guid.Parse("560495e7-05e4-40ef-8836-3eff13de1308");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skim Scroll",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c4b6f7a-11ed-493c-86a9-292dc0956401"), Type = TextBlockType.Text, Text = "You can activate the magic of a scroll with a cursory read as you draw it from your belt. You (action: Interact) to draw forth a scroll, then use (feat: Trick Magic Item) on the scroll." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e8d1fe6b-b886-485c-b9d8-41d2a1ea77cb"), Feats.Instances.ScrollTricksterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e394bc0-c424-42d3-9c62-5403c02376d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
