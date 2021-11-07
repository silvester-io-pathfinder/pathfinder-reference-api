using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cynical : Template
    {
        public static readonly Guid ID = Guid.Parse("a801d59a-5240-4ab7-8a4d-edbd072c3b99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cynical",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("da68ac82-1cc8-4bfe-b06f-83443fe0d775"), Type = TextBlockType.Text, Text = "You’ve been approached with suspicion and distrust throughout your life and return these sentiments back to the strangers you encounter. As a result, you are difficult to deceive. You gain a +1 circumstance bonus to your Perception DC against (action: Lies | Lie) and (action: Impersonations | Impersonate)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a43fac8-778f-43e9-b742-8f35b3c15a66"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
