using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvironmentalExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("71ea8a56-cc2e-4452-a58c-776cf9118705");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Environmental Explorer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a4622bed-4770-416b-8cd0-2010c462b04a"), Type = TextBlockType.Text, Text = "You've traversed enough untamed wilderness to gain an intuitive understanding of the dangers that exist in such places. Your extensive familiarity means you sometimes notice perils even when you're not trying to. Even if you aren't (action: Searching | Search) in exploration mode, you can attempt a check to find environmental hazards that normally require you to (action: Search) for them. You still need to meet any other requirements to find a particular hazard." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("96b22cd4-d612-4f4c-8f65-1c0241ff9e95"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75d59a3a-9063-49fc-866a-75e2008fb13a"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
