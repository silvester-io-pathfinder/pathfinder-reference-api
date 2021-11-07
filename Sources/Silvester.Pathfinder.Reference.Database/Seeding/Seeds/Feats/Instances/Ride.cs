using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Ride : Template
    {
        public static readonly Guid ID = Guid.Parse("75958e8a-46b6-421a-a84e-c5304eedaa8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ride",
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
            yield return new TextBlock { Id = Guid.Parse("f182f3b2-0039-4d26-af52-924ace07e0b3"), Type = TextBlockType.Text, Text = "When you (Action: Command an Animal) you’re mounted on to take a move action (such as (Action: Stride)), you automatically succeed instead of needing to attempt a check. Any animal you’re mounted on acts on your turn, like a minion. If you (Action: Mount | Mount / Dismount) an animal in the middle of an encounter, it skips its next turn and then acts on your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7f0d397-dff7-45d5-b254-590a0bc880c9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
