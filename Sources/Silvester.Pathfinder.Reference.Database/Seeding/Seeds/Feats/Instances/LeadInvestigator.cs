using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadInvestigator : Template
    {
        public static readonly Guid ID = Guid.Parse("5b9a8ddd-eec3-4cf9-9ed3-5939f0a709b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lead Investigator",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5fe2794-13ef-4ec4-9ec5-affb14ccbf8a"), Type = TextBlockType.Text, Text = "You spend 1 minute briefing up to four allies about one lead you&#39;re pursuing. Those allies gain the same circumstance bonus you do from (feat: Pursue a Lead) to checks to investigate that lead. This bonus lasts until you cease pursing that lead or for 1 day, whichever comes first. This doesn&#39;t confer any other benefits of pursuing a lead, such as adding the circumstance bonus to your saves with (feat: Detective&#39;s Readiness)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ad1539a5-1261-4a9f-af2a-7e5b7a4d2caa"), Feats.Instances.ClueThemAllIn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f79c604e-660c-4299-b058-e5ffe9005686"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
