using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScoutsWarning : Template
    {
        public static readonly Guid ID = Guid.Parse("7c4ec873-2a3f-4d9f-b991-81133bcee6ae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Warning",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll a Perception or Survival check for initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("517572df-32ee-41f9-b4c5-578fd9705b49"), Type = TextBlockType.Text, Text = "You visually or audibly warn your allies of danger, granting them each a +1 circumstance bonus to their initiative rolls. Depending on whether you use gestures or call out, this action gains either the (trait: visual) or (trait: auditory) trait, respectively." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44a456ba-563d-4254-ae02-146f659601b2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
