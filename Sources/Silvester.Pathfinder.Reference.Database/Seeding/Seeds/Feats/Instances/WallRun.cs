using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WallRun : Template
    {
        public static readonly Guid ID = Guid.Parse("4da3aeeb-9d1b-422d-9c70-38ae0832638d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wall Run",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("000df182-07eb-4ce9-b5d5-69d04ad6d556"), Type = TextBlockType.Text, Text = "You defy gravity, traversing vertical planes as easily as the ground. (action: Stride) up to your Speed. You must start your movement on a horizontal surface. During this movement, you can run up vertical surfaces, like walls, at your full Speed. If you end the (action: Stride) off the ground, you fall after taking your next action or when your turn ends, whichever comes first (though you can (action: Grab an Edge), if applicable). If you have (feat: Water Step) or a similar ability, Wall Run lets you run along flimsy vertical surfaces, as well as vertical liquids, such as a waterfall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe77ee75-e3ae-4bb9-a566-ec9c5dd5517f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
