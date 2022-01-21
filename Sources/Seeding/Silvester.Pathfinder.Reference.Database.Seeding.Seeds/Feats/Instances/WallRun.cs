using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WallRun : Template
    {
        public static readonly Guid ID = Guid.Parse("91fc8fb0-fd06-4474-8aba-6cee47696d57");

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
            yield return new TextBlock { Id = Guid.Parse("b2ddda69-3b8d-45f7-8538-8faca74493b3"), Type = TextBlockType.Text, Text = "You defy gravity, traversing vertical planes as easily as the ground. (action: Stride) up to your Speed. You must start your movement on a horizontal surface. During this movement, you can run up vertical surfaces, like walls, at your full Speed. If you end the (action: Stride) off the ground, you fall after taking your next action or when your turn ends, whichever comes first (though you can (action: Grab an Edge), if applicable). If you have (feat: Water Step) or a similar ability, Wall Run lets you run along flimsy vertical surfaces, as well as vertical liquids, such as a waterfall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7fff4cd-117d-41f7-8b39-6047237dbf66"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}