using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AgelessPatience : Template
    {
        public static readonly Guid ID = Guid.Parse("19703d16-ff06-437f-a326-5de6fc5dfb25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ageless Patience",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4c73e5ff-450f-4142-8117-b2ca539605e6"), Type = TextBlockType.Text, Text = "You work at a pace born from longevity that enhances your thoroughness. You can voluntarily spend twice as much time as normal on a Perception check or skill check to gain a +2 circumstance bonus to that check. You also don’t treat a natural 1 as worse than usual on these checks; you get a critical failure only if your result is 10 lower than the DC. For example, you could get these benefits if you spent 2 actions to Seek, which normally takes 1 action. You can get these benefits during exploration by taking twice as long exploring as normal, or in downtime by spending twice as much downtime." };
            yield return new TextBlock { Id = Guid.Parse("13e401d4-9c40-4517-b61a-87a02fae70da"), Type = TextBlockType.Text, Text = "The GM might determine a situation doesn’t grant you a benefit if a delay would be directly counterproductive to your success, such as a tense negotiation with an impatient creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a1a7f02-353b-4776-af68-9a6884e50532"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
