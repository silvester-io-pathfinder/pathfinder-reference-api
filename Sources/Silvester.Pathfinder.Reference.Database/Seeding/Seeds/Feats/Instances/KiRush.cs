using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KiRush : Template
    {
        public static readonly Guid ID = Guid.Parse("ee2b4a3d-f539-4fed-922b-285468ba7591");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ki Rush",
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
            yield return new TextBlock { Id = Guid.Parse("76c2efcc-39a0-4fd0-9082-4798650c87e9"), Type = TextBlockType.Text, Text = "You can use ki to move with extraordinary speed and make yourself harder to hit. You gain the (spell: ki rush) ki spell and a focus pool of 1 Focus Point." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8938fd0c-5d23-44e5-99ff-464c395f003b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
