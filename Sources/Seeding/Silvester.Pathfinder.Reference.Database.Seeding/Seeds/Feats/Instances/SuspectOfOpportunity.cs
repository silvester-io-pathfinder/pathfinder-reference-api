using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuspectOfOpportunity : Template
    {
        public static readonly Guid ID = Guid.Parse("84c90b9a-144f-4257-aa01-83c50b42be01");

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
            yield return new TextBlock { Id = Guid.Parse("3ea2edc3-7c2c-4cbc-9a0a-470a4ff03a3d"), Type = TextBlockType.Text, Text = "Sometimes something intrudes upon your case unexpectedly, such as an ambush sent to bring your investigation to a close. You've learned how to compartmentalize your main lead and pursue a new one for your current predicament. You (feat: Pursue a Lead) against the triggering foe, setting aside but not ending one of your currently active leads, if you have two leads. At the end of the combat encounter, you stop (feat: Pursuing the Lead | Pursue a Lead) against the triggering foe and return to the original lead, if you have one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5707776f-266d-4784-a931-ae0636298d02"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
