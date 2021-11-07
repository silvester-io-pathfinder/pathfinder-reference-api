using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NoEscape : Template
    {
        public static readonly Guid ID = Guid.Parse("e56e9ce3-5da3-4851-95e5-99e600ca1182");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "No Escape",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe within reach attempts to move away from you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec9f8a94-9d3b-413c-9b02-e9f3c82e3be2"), Type = TextBlockType.Text, Text = "You keep pace with a retreating foe. (Action: Stride) up to your Speed, following the foe and keeping it in reach throughout its movement until it stops moving or you’ve moved your full Speed. You can use No Escape to (Action: Burrow), (Action: Climb), (Action: Fly), or (Action: Swim) instead of (Action: Stride) if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("19f8d863-8538-4cf1-8065-957bda2e57e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
