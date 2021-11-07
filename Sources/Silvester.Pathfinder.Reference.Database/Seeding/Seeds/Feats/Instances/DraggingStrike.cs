using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraggingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("9d27495b-f61c-4392-9bb3-094ab7e0d795");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragging Strike",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc851828-6cb4-4f31-95d6-c54fff2eab33"), Type = TextBlockType.Text, Text = "You aim your weapon to snag a foe’s armor, clothing, or flesh to pull them closer. Make a melee (action: Strike). If you hit a target that is your size or smaller, that creature is flat-footed until the end of your current turn, and you can move it 5 feet toward you. When you move the creature, you can move the same distance in the same direction as it, even if you’re adjacent to the target. This movement doesn’t trigger reactions." };
            yield return new TextBlock { Id = Guid.Parse("5fd7b4a5-d1ce-4139-b62d-44d5345d1b50"), Type = TextBlockType.Text, Text = "This (action: Strike) has the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("bc5eea18-330a-4895-846b-cd7f8324a6a2"),
                
                
                Failure = "The target becomes flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("190063d5-e1f1-4c8b-a390-cd8b06372d65"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
