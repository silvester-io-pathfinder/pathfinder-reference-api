using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Woodcraft : Template
    {
        public static readonly Guid ID = Guid.Parse("002dec35-3b73-4144-8c7b-c7b858481c6f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Woodcraft",
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
            yield return new TextBlock { Id = Guid.Parse("7eca7551-b96b-424d-b71d-cd1c3b0513b2"), Type = TextBlockType.Text, Text = "You have a innate familiarity with forested areas. When in a forest or jungle environment, if you roll a critical failure on a Survival skill check to (Action: Sense Direction), (Action: Subsist), or (Action: Cover Tracks), you get a failure instead, and if you roll a success, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3df5580-3016-48a4-b9e9-f35eb0e71923"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
