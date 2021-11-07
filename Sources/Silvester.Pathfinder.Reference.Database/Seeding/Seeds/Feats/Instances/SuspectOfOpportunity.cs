using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuspectOfOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("9b6e30c4-042d-4ce3-91e3-cdd763e47a48");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Suspect of Opportunity",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A foe takes a hostile action against you in combat.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7158c249-3fe5-4e5c-9213-e66d3a7c1fd5"), Type = TextBlockType.Text, Text = "Sometimes something intrudes upon your case unexpectedly, such as an ambush sent to bring your investigation to a close. You&#39;ve learned how to compartmentalize your main lead and pursue a new one for your current predicament. You (feat: Pursue a Lead) against the triggering foe, setting aside but not ending one of your currently active leads, if you have two leads. At the end of the combat encounter, you stop (feat: Pursuing the Lead | Pursue a Lead) against the triggering foe and return to the original lead, if you have one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("593bdf7a-3c68-44f7-a888-0c1d0f8ee559"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
