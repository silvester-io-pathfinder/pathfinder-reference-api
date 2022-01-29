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
    public class Upstage : Template
    {
        public static readonly Guid ID = Guid.Parse("6d04a625-d71e-4bbd-ae3f-dc0f39fadf86");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Upstage",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe attempts a skill check and doesn't get a critical success.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c531041a-c626-4594-9bfb-e74338bd6229"), Type = TextBlockType.Text, Text = $"After your foe has tried their best, you show everyone how it's really done. Attempt a check using the same skill that triggered this reaction." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ac056ebb-f7c7-47ae-8cfd-ef10bdd42874"),
                CriticalSuccess = "You gain a +1 status bonus to attack rolls, Perception checks, saving throws, and skill checks until the end of your next turn.",
                Success = "As critical success, except you gain the benefits only if the triggering creature failed their skill check.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0189e75d-4c73-4fd1-9e5a-3e162dda1803"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
