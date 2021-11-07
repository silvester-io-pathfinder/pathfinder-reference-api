using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmbersEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("b47f44c5-b362-4d2f-9502-ede8e1d2cba5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ember's Eyes",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "If your ancestry has neither low-light vision nor darkvision, you can take this ancestry feat a second time to gain darkvision. You can't retrain out of this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7a73c6c9-d094-4488-8df8-084256a2068f"), Type = TextBlockType.Text, Text = "Your eyes blaze with inner flame. You gain low-light vision, or you gain darkvision if your ancestry already has low-light vision." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf34927d-eb10-4f56-954a-cf21a23f0f65"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
