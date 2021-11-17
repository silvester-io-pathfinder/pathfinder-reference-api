using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnointAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("f813279a-3b35-4ed3-8914-7dba49bda5e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anoint Ally",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26b02a23-2fb5-429b-836e-efb49ac6ae97"), Type = TextBlockType.Text, Text = "You forge a mystical connection with an ally using your body as a focus, allowing them to benefit from your magic. You place a blood rune on an adjacent ally that lasts for 1 minute. When you would gain a blood magic effect, you can forgo it, granting it to your ally instead. You can anoint only one ally at a time; if you place another rune, your previous designation ends." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("858b48c8-e69a-4d48-bd2d-fbc8f492e3f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
