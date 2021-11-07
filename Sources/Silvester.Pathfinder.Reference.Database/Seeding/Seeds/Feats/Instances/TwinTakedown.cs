using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinTakedown : Template
    {
        public static readonly Guid ID = Guid.Parse("f291c9e5-98d3-4ee5-a29c-9d19004738e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Takedown",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("888109a8-531d-4331-a02d-6824c805963a"), Type = TextBlockType.Text, Text = "You swiftly attack your hunted prey with both weapons. Make two (action: Strikes | Strike) against your hunted prey, one with each of the required weapons. If both hit the same hunted prey, combine their damage for the purpose of its resistances and weaknesses. Apply your multiple attack penalty to each (action: Strike) normally." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0acf62f-2a2d-45e3-b348-e58d05ac13b5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
