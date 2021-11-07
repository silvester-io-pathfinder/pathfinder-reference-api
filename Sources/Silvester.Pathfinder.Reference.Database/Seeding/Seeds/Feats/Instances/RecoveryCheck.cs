using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RecoveryCheck : Template
    {
        public static readonly Guid ID = Guid.Parse("28123296-4179-4e10-9982-670ef2781a3d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Recovery Check",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49147a0e-f554-4524-a3c3-e351f9e8ca40"), Type = TextBlockType.Text, Text = "When you’re dying, at the start of each of your turns, you must attempt a flat check with a DC equal to 10 + your current dying value to see if you get better or worse. The effects of this check are as follows." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("25c41143-40f9-4c50-bbf1-f43cf3480821"),
                CriticalSuccess = "Your dying value is reduced by 2.",
                Success = "Your dying value is reduced by 1.",
                Failure = "Your dying value increases by 1.",
                CriticalFailure = "Your dying value increases by 2.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bafce81-58db-480f-9993-8f706200b953"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
