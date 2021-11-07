using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DiamondSoul : Template
    {
        public static readonly Guid ID = Guid.Parse("a77b2eb7-1674-4bac-8f03-270f02c4ff39");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diamond Soul",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e41e872-370d-4e42-b63f-4ba0d44eeb59"), Type = TextBlockType.Text, Text = "You have fortified your body and mind against eldritch effects. You gain a +1 status bonus to saving throws against magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bd14a04-2614-4141-8d7e-38eaab84d6fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
