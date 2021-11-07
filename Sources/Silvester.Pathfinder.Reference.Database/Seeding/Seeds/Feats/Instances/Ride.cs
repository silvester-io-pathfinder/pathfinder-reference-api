using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Ride : Template
    {
        public static readonly Guid ID = Guid.Parse("90ea40e1-6581-404e-b886-73af9cc6a4ef");

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
            yield return new TextBlock { Id = Guid.Parse("747eac7f-ca2a-4d3d-a892-117a5e5ea82f"), Type = TextBlockType.Text, Text = "When you (Action: Command an Animal) you’re mounted on to take a move action (such as (Action: Stride)), you automatically succeed instead of needing to attempt a check. Any animal you’re mounted on acts on your turn, like a minion. If you (Action: Mount | Mount / Dismount) an animal in the middle of an encounter, it skips its next turn and then acts on your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0598801-7b4c-4883-991d-99117e19327b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
