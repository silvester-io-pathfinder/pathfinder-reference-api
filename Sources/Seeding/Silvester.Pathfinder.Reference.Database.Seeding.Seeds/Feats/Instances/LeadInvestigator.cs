using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeadInvestigator : Template
    {
        public static readonly Guid ID = Guid.Parse("0009a7c6-4ffd-4811-9231-be2a765bbea9");

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
            yield return new TextBlock { Id = Guid.Parse("5fe6d117-d896-4dbc-9771-c06e5b81160a"), Type = TextBlockType.Text, Text = "You spend 1 minute briefing up to four allies about one lead you're pursuing. Those allies gain the same circumstance bonus you do from (feat: Pursue a Lead) to checks to investigate that lead. This bonus lasts until you cease pursing that lead or for 1 day, whichever comes first. This doesn't confer any other benefits of pursuing a lead, such as adding the circumstance bonus to your saves with (feat: Detective's Readiness)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("dddd5270-fca5-499c-a875-f14740133674"), Feats.Instances.ClueThemAllIn.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d9b86049-bb6e-4b89-bc20-ec45992da482"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
