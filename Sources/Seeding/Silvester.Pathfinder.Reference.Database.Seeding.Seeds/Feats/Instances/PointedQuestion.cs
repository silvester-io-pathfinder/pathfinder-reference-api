using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PointedQuestion : Template
    {
        public static readonly Guid ID = Guid.Parse("53d765cd-3f54-44d9-842e-517979d66ba6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pointed Question",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc06a627-3e46-4829-89dd-05b1256be0cb"), Type = TextBlockType.Text, Text = $"You ask a question that charms or needles someone in just the right way. Ask a question of a non-allied creature that you can see and have been conversing with. Attempt a Diplomacy check against the creature's Will DC. The creature is then temporarily immune for 1 hour." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("565f3f05-7e1b-4331-88af-18d5d4cf7f91"),
                CriticalSuccess = "The target must directly answer your question. It doesn't have to answer truthfully, but you gain a +4 circumstance bonus to your Perception DC if the creature attempts to (action: Lie) to you.",
                Success = "As critical success, but the circumstance bonus is +2.",
                Failure = "The target can refuse to answer you as normal.",
                CriticalFailure = "The target can refuse to answer you as normal, and its attitude toward you decreases by one step due to your aggravating attention.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7ba9dd1-f5ef-49c7-b37d-180e995ab470"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
