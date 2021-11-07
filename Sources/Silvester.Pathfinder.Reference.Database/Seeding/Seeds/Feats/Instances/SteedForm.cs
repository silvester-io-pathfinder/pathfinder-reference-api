using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("eebe582b-9c4f-464b-ba58-18ee86d1138e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steed Form",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e6c5e0c7-daae-4b74-910b-35ade95db8fa"), Type = TextBlockType.Text, Text = "Your eidolon changes to make it particularly effective as your mount. While you ride it, you get your full number of actions each round instead of reducing them to 2. This applies only when you ride your eidolon, not when anyone else does (see the Riding Sapient Creatures sidebar on SoM pg. 71). Your eidolon still must be at least one size category larger than you to ride it. Since you work together to move, your eidolon’s (trait: move) actions while you’re mounted gain the (trait: tandem) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ffa33823-e82c-41ea-b224-1bb86dcf3edf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
