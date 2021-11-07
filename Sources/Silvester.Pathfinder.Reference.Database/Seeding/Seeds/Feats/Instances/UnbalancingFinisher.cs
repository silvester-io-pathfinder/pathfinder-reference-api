using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnbalancingFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("83087995-50c1-4a1c-ad44-91ef7272ee79");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unbalancing Finisher",
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
            yield return new TextBlock { Id = Guid.Parse("5b4870f9-acef-4b76-aa5f-0adaabf53a26"), Type = TextBlockType.Text, Text = "You attack with a flashy assault that leaves your target off balance. Make a melee (action: Strike). If you hit and deal damage, the target is flat-footed until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("381d7201-cf93-424e-a6fc-262de16520ba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
