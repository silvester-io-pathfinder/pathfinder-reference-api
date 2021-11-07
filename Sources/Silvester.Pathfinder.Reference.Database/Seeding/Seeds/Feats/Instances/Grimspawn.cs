using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Grimspawn : Template
    {
        public static readonly Guid ID = Guid.Parse("bd39b787-67a6-4ab1-8594-876136b59f63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grimspawn",
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
            yield return new TextBlock { Id = Guid.Parse("65938545-a3f2-42b3-a1ba-e369e3ec3d8f"), Type = TextBlockType.Text, Text = "Your lineage traces back to a daemon, one of the manifestations of horrific forms of death that devour souls within their foul home of Abaddon. As a result, you cling tenaciously to the last shreds of your own life force. You gain the (feat: Diehard) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b89455eb-3259-43f0-9ab6-23d210da2f94"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
