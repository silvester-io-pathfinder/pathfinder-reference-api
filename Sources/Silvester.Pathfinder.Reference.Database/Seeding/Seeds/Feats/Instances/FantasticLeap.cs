using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FantasticLeap : Template
    {
        public static readonly Guid ID = Guid.Parse("dd9f5361-3cae-422d-a0e9-1d70cb7af18e");

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
            yield return new TextBlock { Id = Guid.Parse("88350128-9422-44f3-92c5-8da038344613"), Type = TextBlockType.Text, Text = "You launch yourself through the air at a foe. Attempt a (action: High Jump) or (action: Long Jump). If you attempt a (action: High Jump), determine the distance you can travel using the scale of a (action: Long Jump). At the end of your jump, you can make a melee (action: Strike)." };
            yield return new TextBlock { Id = Guid.Parse("4a540928-073e-4676-a56a-956197248f29"), Type = TextBlockType.Text, Text = "After your (action: Strike), you fall to the ground if you’re in the air. If the distance of your fall is no more than the height of your jump, you take no damage and land upright." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("994b1b1a-08f1-4189-bd1b-023b1adce64a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
