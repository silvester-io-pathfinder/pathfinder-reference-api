using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DancingLeaf : Template
    {
        public static readonly Guid ID = Guid.Parse("9e2ba69e-6adf-4284-b7ff-6968b97dbf51");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dancing Leaf",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88800921-ae7c-4b6b-975e-0cd20189105f"), Type = TextBlockType.Text, Text = "You are as light as a leaf whirling in the breeze. When you (action: Leap) or succeed at a (action: High Jump) or (action: Long Jump), increase the distance you jump by 5 feet. When calculating the damage you take from falling, don’t count any distance fallen while you are adjacent to a wall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("480173d4-b902-4b61-a903-157c82e3a81e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
