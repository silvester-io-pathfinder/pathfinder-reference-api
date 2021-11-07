using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SleeperHold : Template
    {
        public static readonly Guid ID = Guid.Parse("42defc92-a80f-4a02-935e-8141caca6842");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sleeper Hold",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b454671-83f5-4f89-a02c-8fb9858f774c"), Type = TextBlockType.Text, Text = "You pinch crucial points of your target’s nervous system, impeding its ability to function. Attempt an Athletics check to (action: Grapple) the creature, with the following success and critical success effects instead of the usual effects." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e1206078-deb1-4f3f-9acc-0f8624e19afc"),
                CriticalSuccess = "The target falls unconscious for 1 minute, though it remains standing and doesn’t drop what it holds.",
                Success = "The target is clumsy 1 until the end of its next turn.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6fe9da82-bfae-46e4-ad56-8d584640d758"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
