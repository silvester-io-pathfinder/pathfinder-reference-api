using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SilencingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("f5466eb4-7d3d-4efa-833a-dbb1603e00fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Silencing Strike",
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
            yield return new TextBlock { Id = Guid.Parse("bb5cf01d-88f5-44de-81fc-1df4944c5a3a"), Type = TextBlockType.Text, Text = "A quick strike to the face or mouth silences your opponent. Make a melee (action: Strike) against a foe. The foe must succeed at a Fortitude save against your class DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("dd67795a-8658-4b5b-8a1f-2ac2eda0158b"),
                
                Success = "The target is unaffected.",
                Failure = "The target is dazed and can barely vocalize. It’s stunned 1 and its speech is raspy and hard to understand. It must succeed at a DC 11 flat check to use (trait: linguistic) actions or supply verbal spellcasting components until the end of its next turn.",
                CriticalFailure = "As failure, but the creature is stunned 3 instead of stunned 1.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86cccd36-c0ac-465e-a37f-9733d39757bd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
