using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SteedForm : Template
    {
        public static readonly Guid ID = Guid.Parse("1e73ae1f-9e9a-4ce9-883a-4bd65d21cb88");

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
            yield return new TextBlock { Id = Guid.Parse("87173d1c-66d1-435a-a940-729c410055e0"), Type = TextBlockType.Text, Text = "Your eidolon changes to make it particularly effective as your mount. While you ride it, you get your full number of actions each round instead of reducing them to 2. This applies only when you ride your eidolon, not when anyone else does (see the Riding Sapient Creatures sidebar on SoM pg. 71). Your eidolon still must be at least one size category larger than you to ride it. Since you work together to move, your eidolon's (trait: move) actions while you're mounted gain the (trait: tandem) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a9d8edb-bf83-4b82-b996-3a1c26e33637"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
