using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactivePursuit : Template
    {
        public static readonly Guid ID = Guid.Parse("8f313993-42d4-497e-8d3f-4c7259aa9e61");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Pursuit",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An adjacent foe moves away from you, and you can reach at least one space adjacent to the foe with a Stride action.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a7f37b4c-304b-41ca-a85a-d350dd192d01"), Type = TextBlockType.Text, Text = "You keep pace with a retreating foe. You (action: Stride), but you must end your movement adjacent to the triggering enemy. Your move does not trigger reactions from the triggering enemy. You can use Reactive Pursuit to (action: Burrow), (action: Climb), (action: Fly), or (action: Swim) instead of (action: Stride) if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9d4b0d3-6e0e-4b2a-b92e-1707a3371545"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
