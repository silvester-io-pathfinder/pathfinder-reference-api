using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WingThrash : Template
    {
        public static readonly Guid ID = Guid.Parse("34097598-fb6e-4a38-8d1e-b4d3dc4bf37c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wing Thrash",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("67d92e1b-a860-4ce1-a41f-25e28f9d581b"), Type = TextBlockType.Text, Text = "The bat thrashes wildly with its wings, making wing (action: Strikes | Strike) against up to three adjacent foes. Each attack counts toward the bat’s multiple attack penalty, but the penalty only increases after all the attacks have been made." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("acd1888a-ccb0-4e9b-adb8-002ecd2e2941"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
