using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpeditiousAdvance : Template
    {
        public static readonly Guid ID = Guid.Parse("d416a4f2-3149-4a99-95a3-098ac023c436");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expeditious Advance",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c067f0a-c122-45bf-b7af-7148a9a3553d"), Type = TextBlockType.Text, Text = "You advance and retreat quickly. You gain a +10-foot status bonus to your speed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("39e00b02-167a-450f-8668-02d2ff9da91f"), Feats.Instances.LionBladeDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9f06dc5-787b-4ebd-853b-14588dfaa9f7"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
