using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnointAlly : Template
    {
        public static readonly Guid ID = Guid.Parse("cb790275-83f4-494b-9675-17826bae1dbe");

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
            yield return new TextBlock { Id = Guid.Parse("e107de23-0352-40ff-ac24-1924c6e93d87"), Type = TextBlockType.Text, Text = "You forge a mystical connection with an ally using your body as a focus, allowing them to benefit from your magic. You place a blood rune on an adjacent ally that lasts for 1 minute. When you would gain a blood magic effect, you can forgo it, granting it to your ally instead. You can anoint only one ally at a time; if you place another rune, your previous designation ends." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5bcd812-262c-4e6e-b871-673c12e4506a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
