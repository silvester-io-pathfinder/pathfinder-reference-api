using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FantasticLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("028a3b00-7858-4115-b087-01ad1ce8a9a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fantastic Leap",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("632fd1d8-7186-4ab3-b139-f480203b8a80"), Type = TextBlockType.Text, Text = "You launch yourself through the air at a foe. Attempt a (action: High Jump) or (action: Long Jump). If you attempt a (action: High Jump), determine the distance you can travel using the scale of a (action: Long Jump). At the end of your jump, you can make a melee (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("28eb30df-3296-40c2-a9d5-5a6af9bc2ab0"), Type = TextBlockType.Text, Text = "After your (action: Strike), you fall to the ground if you’re in the air. If the distance of your fall is no more than the height of your jump, you take no damage and land upright." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b29ffe3f-42e5-45c0-96e8-15ecc3dcfacd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
