using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TimelessNature : Template
    {
        public static readonly Guid ID = Guid.Parse("c58d4453-a29d-41fa-8fac-0ba182435cd4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Timeless Nature",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b4374999-4c57-443c-89c6-647f377d6c35"), Type = TextBlockType.Text, Text = "With primal magic sustaining you, you cease aging. The overflowing primal energy gives you a +2 status bonus to saves against diseases and primal magic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49c06615-92c9-4b1c-9d3b-4265b8ff5440"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
