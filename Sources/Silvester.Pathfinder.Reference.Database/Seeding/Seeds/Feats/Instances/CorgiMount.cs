using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CorgiMount : Template
    {
        public static readonly Guid ID = Guid.Parse("e0895d04-16be-4953-831b-4e5748eb75c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Corgi Mount",
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
            yield return new TextBlock { Id = Guid.Parse("52b9e1da-8c92-4203-b945-bf25a813731c"), Type = TextBlockType.Text, Text = "The smallest of fey have ridden corgis as mounts since time immemorial, leading to a pattern on corgis’ backs called a “faerie saddle.” You have formed a magical connection with a corgi that can serve as your mount. Your corgi familiar is Small rather than Tiny, and it’s appropriate for use as your mount, unlike most familiars. It has the scent ability, which counts against your limit for familiar and master abilities as normal. Furthermore, it can never gain a familiar ability that grants it any Speeds other than a land Speed. If you’re a pixie, you can’t ride a corgi due to your Size, but you can take this feat to gain a corgi familiar." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e358a9ba-d78a-4fc7-96c5-0c1e250be6ee"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
