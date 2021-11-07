using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GleanLore : Template
    {
        public static readonly Guid ID = Guid.Parse("0c738284-2ffb-420c-814a-0eb8d0fd654e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glean Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a09ff59-ca4e-4bf1-8cf9-64c647767dd5"), Type = TextBlockType.Text, Text = "You tap into the collected lore of the divine, accessing a variety of potentially useful information. Attempt a Religion check to understand the information you gain. The GM sets the DC (similar to the DC to (action: Recall Knowledge)), potentially adjusting the DC of the check for topics far removed from your mystery." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("035be0d0-4e1e-4083-8c9f-5d662c13d4bf"),
                CriticalSuccess = "You comprehend the lore accurately or gain a useful clue from the divine about your situation.",
                Success = "You learn two pieces of information about the topic, one true and one erroneous, but you don’t know which is which.",
                Failure = "You recall incorrect information or gain an erroneous or misleading clue.",
                CriticalFailure = "You recall two pieces of incorrect information or gain two erroneous or misleading clues.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a2935e3-6eb1-4bda-b9e9-49f9a0469f64"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
