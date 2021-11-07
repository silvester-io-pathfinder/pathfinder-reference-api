using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Upstage : Template
    {
        public static readonly Guid ID = Guid.Parse("2089ab44-c7b6-47b7-9c6f-fa9b801f4112");

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
            yield return new TextBlock { Id = Guid.Parse("6559e983-fa92-42b9-8cb9-60efd6a2f7be"), Type = TextBlockType.Text, Text = "After your foe has tried their best, you show everyone how it’s really done. Attempt a check using the same skill that triggered this reaction." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("cbdb3b4c-933f-4057-9d94-3a1a60799102"),
                CriticalSuccess = "You gain a +1 status bonus to attack rolls, Perception checks, saving throws, and skill checks until the end of your next turn.",
                Success = "As critical success, except you gain the benefits only if the triggering creature failed their skill check.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e7d1e93-27be-447c-b863-db718a432d4b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
