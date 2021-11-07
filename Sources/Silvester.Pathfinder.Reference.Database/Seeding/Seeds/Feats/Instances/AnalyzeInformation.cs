using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnalyzeInformation : Template
    {
        public static readonly Guid ID = Guid.Parse("437ef166-a1f8-4e68-a1a7-3d18a814d845");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Analyze Information",
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
            yield return new TextBlock { Id = Guid.Parse("e0a9aa70-1da0-4916-81e0-3bbccdc6b866"), Type = TextBlockType.Text, Text = "You can stoke your mind into a burst of analytical prowess. You can cast 3rd-level (spell: hypercognition) once per day as a divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c542d17-7cb0-47de-9a00-b75fc29064b9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
