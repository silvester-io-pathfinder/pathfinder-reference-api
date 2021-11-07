using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HazardFinder : Template
    {
        public static readonly Guid ID = Guid.Parse("06ce719a-0674-48c1-9f57-8d9ab8fa5a10");

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
            yield return new TextBlock { Id = Guid.Parse("54e64b46-9f68-4749-a90d-e0d46f9fa65b"), Type = TextBlockType.Text, Text = "You have an intuitive ability to sense hazards. You gain a +1 circumstance bonus to Perception checks to find traps and hazards, to AC against their attacks, and to saves against their effects. You can find hazards that would normally require you to (action: Search) even if you aren’t (action: Searching | Search)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc3f2bff-d2f1-4bd0-a52e-b7af31399b6f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
