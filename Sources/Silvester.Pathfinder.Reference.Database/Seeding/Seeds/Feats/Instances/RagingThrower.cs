using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RagingThrower : Template
    {
        public static readonly Guid ID = Guid.Parse("5f467fbd-b1d6-41f1-957a-717d22a5dde3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raging Thrower",
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
            yield return new TextBlock { Id = Guid.Parse("855036ad-3bf3-4eca-893a-ed70e22d495c"), Type = TextBlockType.Text, Text = "Thrown weapons become especially deadly in your fury. You apply the additional damage from (Action: Rage) to your thrown weapon attacks. If you have the (Feat: Brutal Critical) feat or the devastator class feature, apply their benefits to thrown weapon attacks." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7e820d0-eb55-4950-8757-19c874b3be45"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
