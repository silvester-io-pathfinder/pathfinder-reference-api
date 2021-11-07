using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HazardFinder : Template
    {
        public static readonly Guid ID = Guid.Parse("3db3d565-941e-42c1-981c-34a02e2d7672");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hazard Finder",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98afd9c6-ca3b-4675-a98e-7e2a5f45aeaf"), Type = TextBlockType.Text, Text = "You have an intuitive ability to sense hazards. You gain a +1 circumstance bonus to Perception checks to find traps and hazards, to AC against their attacks, and to saves against their effects. You can find hazards that would normally require you to (action: Search) even if you aren’t (action: Searching | Search)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38e418c7-58b9-4f7e-a6f9-77f4ef4d5627"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
