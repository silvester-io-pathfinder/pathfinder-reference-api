using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Jinx : Template
    {
        public static readonly Guid ID = Guid.Parse("b08065f6-2503-4cc9-90fc-e59075104d8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jinx",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("094c12b7-615b-4a85-bf45-6834f9bb2acd"), Type = TextBlockType.Text, Text = "You can curse another creature with clumsiness. This curse has a range of 30 feet, and you must be able to see your target. The target gets a Will saving throw to resist this jinx, using your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("0584930d-af9f-40f8-8438-437c4f61d819"),
                
                Success = "The target is unaffected and is temporarily immune for 24 hours.",
                Failure = "The target is clumsy 1 for 1 minute.",
                CriticalFailure = "The target is clumsy 2 for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a265922-66bb-42b5-8ff0-8bd67ca6e585"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
