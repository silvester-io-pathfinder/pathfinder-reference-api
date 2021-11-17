using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Jinx : Template
    {
        public static readonly Guid ID = Guid.Parse("222dafce-7b64-4711-be7a-6a2ca1f7c04b");

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
            yield return new TextBlock { Id = Guid.Parse("759647ff-22db-4d7a-959b-0fd70a0a3ef7"), Type = TextBlockType.Text, Text = "You can curse another creature with clumsiness. This curse has a range of 30 feet, and you must be able to see your target. The target gets a Will saving throw to resist this jinx, using your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("51e10509-a896-4c6c-a721-ee58e798f795"),
                
                Success = "The target is unaffected and is temporarily immune for 24 hours.",
                Failure = "The target is clumsy 1 for 1 minute.",
                CriticalFailure = "The target is clumsy 2 for 1 minute.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ebc0818-c177-4e01-8167-d9b40774fa50"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
