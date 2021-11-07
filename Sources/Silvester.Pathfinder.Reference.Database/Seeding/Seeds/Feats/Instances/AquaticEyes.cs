using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AquaticEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("1510c098-0c63-4463-8b7b-c10d2a34ed0c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aquatic Eyes",
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
            yield return new TextBlock { Id = Guid.Parse("6af9cf25-f3e7-415a-9fc2-4a7a1eb82db8"), Type = TextBlockType.Text, Text = "As your connection to water grows, you can see more easily in places with less light, such as the depths of the ocean. You gain low-light vision, or you gain darkvision if your ancestry already has low-light vision." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73d74159-c427-4c0f-9b04-67e394ef3cfe"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
