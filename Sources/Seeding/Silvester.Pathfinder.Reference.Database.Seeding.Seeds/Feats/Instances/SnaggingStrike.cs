using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnaggingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b3533f46-4a0a-48ec-bcc5-b50ac415a550");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Snagging Strike",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d5b36d0-aee0-4596-ad08-a44a1d73a109"), Type = TextBlockType.Text, Text = $"You combine an attack with quick grappling moves to throw an enemy off balance as long as it stays in your reach. Make a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} while keeping one hand free. If this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} hits, the target is flat-footed until the start of your next turn or until it's no longer within the reach of your hand, whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b408e116-230b-4d6c-bcac-1ca5823d40ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
