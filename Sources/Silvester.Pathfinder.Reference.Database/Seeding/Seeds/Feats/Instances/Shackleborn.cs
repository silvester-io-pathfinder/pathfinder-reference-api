using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Shackleborn : Template
    {
        public static readonly Guid ID = Guid.Parse("31099f5d-5258-4123-9cbe-649c0cd6ccbb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shackleborn",
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
            yield return new TextBlock { Id = Guid.Parse("87858e0d-ac1c-4396-8ac8-bb45386f5906"), Type = TextBlockType.Text, Text = "Your lineage shows the signs of velstrac tampering, including some curious quirk bequeathed by those shadowy surgeons of flesh and souls. Your flesh heals cleanly and quickly—all the better for you to serve as a subject for their ghastly art. You gain the (feat: Fast Recovery) feat, even if you don’t meet the prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a86cb76-1cb8-4fe9-a60a-bdc0d6090932"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
