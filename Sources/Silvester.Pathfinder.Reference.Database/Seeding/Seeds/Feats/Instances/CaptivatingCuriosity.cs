using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CaptivatingCuriosity : Template
    {
        public static readonly Guid ID = Guid.Parse("2ba2f4a2-22b4-4164-99e8-2f146b67f913");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Captivating Curiosity",
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
            yield return new TextBlock { Id = Guid.Parse("d657354d-d1bb-43c1-9dc1-f97b58288326"), Type = TextBlockType.Text, Text = "You can snare the attentions of onlookers with your unique appearance. You can cast (spell: enthrall) as a 3rd-level occult innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48e6eb9d-2eaf-43db-a647-b682938577e5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
