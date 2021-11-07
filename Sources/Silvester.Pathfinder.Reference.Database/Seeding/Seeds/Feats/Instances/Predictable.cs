using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Predictable : Template
    {
        public static readonly Guid ID = Guid.Parse("16b946e9-eb4f-4503-88e9-9bc7461ccb1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Predictable!",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("240c13e2-b7f4-4600-b452-8a7c879702de"), Type = TextBlockType.Text, Text = "By observing an opponent, you can get a sense of their next move and prepare to counter or resist it. Choose one target and attempt a Perception check to (action: Sense Motive) against the foe’s Deception DC or a hard DC of the foe’s level, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("033498a7-2644-4f9f-96bb-6df20d5aaf36"),
                CriticalSuccess = "You precisely discern the target’s strategy, gaining a +2 circumstance bonus to AC against the creature until the start of your next turn and a +2 circumstance bonus to your next saving throw against the creature before the start of your next turn.",
                Success = "You deduce the gist of the target’s strategy; as critical success, except the circumstance bonus is only +1.",
                Failure = "You fail to discern the target’s strategy and gain no benefit.",
                CriticalFailure = "You misinterpret the target’s strategy and take a –1 circumstance penalty to AC against the creature until the start of your next turn, and a –1 circumstance penalty to your next saving throw against the creature before the start of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa00e03a-d252-41c2-9bd5-8450ec3bcdb0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
