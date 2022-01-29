using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Predictable : Template
    {
        public static readonly Guid ID = Guid.Parse("275caff2-add9-49e3-8b09-2592128289b6");

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
            yield return new TextBlock { Id = Guid.Parse("53da7904-2dfe-4953-9c87-d7c962f99482"), Type = TextBlockType.Text, Text = $"By observing an opponent, you can get a sense of their next move and prepare to counter or resist it. Choose one target and attempt a Perception check to {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} against the foe's Deception DC or a hard DC of the foe's level, whichever is higher." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("35c179ff-e902-4072-9656-59530de0ca4a"),
                CriticalSuccess = "You precisely discern the target's strategy, gaining a +2 circumstance bonus to AC against the creature until the start of your next turn and a +2 circumstance bonus to your next saving throw against the creature before the start of your next turn.",
                Success = "You deduce the gist of the target's strategy; as critical success, except the circumstance bonus is only +1.",
                Failure = "You fail to discern the target's strategy and gain no benefit.",
                CriticalFailure = "You misinterpret the target's strategy and take a –1 circumstance penalty to AC against the creature until the start of your next turn, and a –1 circumstance penalty to your next saving throw against the creature before the start of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("898d63d6-ee66-4c22-859e-cf2942d5baf2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
