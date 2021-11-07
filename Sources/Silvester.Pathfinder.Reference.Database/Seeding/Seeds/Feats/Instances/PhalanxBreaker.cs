using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhalanxBreaker : Template
    {
        public static readonly Guid ID = Guid.Parse("15b319c4-9241-4c67-aec1-c8779014c58a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phalanx Breaker",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22c1b4e0-2dd0-4a68-816f-46011675b3a6"), Type = TextBlockType.Text, Text = "You know that to take out an enemy formation, you must punch a hole through its center. Make a ranged (action: Strike) with the required weapon against a target within the weapon’s first range increment. The target is pushed directly back 10 feet (20 feet on a critical hit), and if this pushes the target into an obstacle, the target takes bludgeoning damage equal to half your level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificGunslingersWay(Guid.Parse("d4838cfb-525e-46a0-a644-f7a7ca4f3b63"), GunslingerWays.Instances.WayOfTheVanguard.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1bbf2e20-a6ab-42fb-a117-58409da5c3b8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
