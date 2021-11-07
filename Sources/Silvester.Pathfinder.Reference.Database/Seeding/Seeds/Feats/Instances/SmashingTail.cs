using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SmashingTail : Template
    {
        public static readonly Guid ID = Guid.Parse("94772071-fc23-45e9-adb0-67ecf4eae71d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Smashing Tail",
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
            yield return new TextBlock { Id = Guid.Parse("911a66fe-f517-4ff5-8184-460602ed7b27"), Type = TextBlockType.Text, Text = "You have a tail that serves as a potent weapon. You gain a tail unarmed attack that deals 1d6 bludgeoning damage, has the (trait: sweep) trait, and is in the brawling weapon group." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3668004-4786-417a-bef3-91303a30dead"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
