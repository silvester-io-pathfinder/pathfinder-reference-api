using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraggingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("d9d2a575-6441-4742-9d11-fbb1aa250069");

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
            yield return new TextBlock { Id = Guid.Parse("7784a13e-b550-4ef9-9dc6-9fe9342a1c7b"), Type = TextBlockType.Text, Text = "You aim your weapon to snag a foe's armor, clothing, or flesh to pull them closer. Make a melee (action: Strike). If you hit a target that is your size or smaller, that creature is flat-footed until the end of your current turn, and you can move it 5 feet toward you. When you move the creature, you can move the same distance in the same direction as it, even if you're adjacent to the target. This movement doesn't trigger reactions." };
            yield return new TextBlock { Id = Guid.Parse("7edb2ffe-e056-462c-ac1b-637b30f0db4e"), Type = TextBlockType.Text, Text = "This (action: Strike) has the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("598c81f3-866e-4d64-a33e-52b009d9a6fe"),
                
                
                Failure = "The target becomes flat-footed until the end of your current turn.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79f59f1a-353d-4713-91ff-e9a28ca23379"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
