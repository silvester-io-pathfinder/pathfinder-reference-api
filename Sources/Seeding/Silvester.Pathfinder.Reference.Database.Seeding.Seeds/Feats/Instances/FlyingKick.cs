using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlyingKick : Template
    {
        public static readonly Guid ID = Guid.Parse("965ab1f0-e78c-4c7a-97f1-74fe0910914c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flying Kick",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("77f64ffc-5664-45b3-90f1-e0b8262ce669"), Type = TextBlockType.Text, Text = "You launch yourself at a foe. Make a (action: Leap) or attempt a (action: High Jump) or (action: Long Jump). At the end of the jump, if you're adjacent to a foe, you can immediately (action: Strike) that foe with an unarmed attack, even if the foe is in mid-air. You fall to the ground after the (action: Strike). If the distance you fall is no more than the height of your jump, you land upright and take no damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72007173-da66-490b-b0ed-678b9089badb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
