using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntenseImplement : Template
    {
        public static readonly Guid ID = Guid.Parse("e8d19791-597a-435c-9ec2-a2cdeaa190b4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intense Implement",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22a2635e-78c6-492e-9cff-2119dbbe4161"), Type = TextBlockType.Text, Text = "You have an exceptional connection to one of your lesser implements, allowing you to tap into more of its power. You gain the adept benefit for one of your implements for which you have only the initiate benefit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebec1cc1-23cc-486e-93ad-01c0494bd33b"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
