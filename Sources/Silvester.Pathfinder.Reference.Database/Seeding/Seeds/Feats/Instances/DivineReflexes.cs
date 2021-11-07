using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("dc95c072-03fc-4443-a154-24930b7459dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Reflexes",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cbdb2ddd-68b7-4450-845e-06feebe2c369"), Type = TextBlockType.Text, Text = "At the start of each of your turns, you gain an additional reaction that you can use only for your champion’s reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a9401a9-92bb-4129-abc1-d6d8cad10eb2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
