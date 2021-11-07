using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnvironmentalExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("8d50a280-4a35-499d-8ad0-28e2297e5964");

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
            yield return new TextBlock { Id = Guid.Parse("6a7ae119-2892-4a74-bd14-de1f528b7d30"), Type = TextBlockType.Text, Text = "You&#39;ve traversed enough untamed wilderness to gain an intuitive understanding of the dangers that exist in such places. Your extensive familiarity means you sometimes notice perils even when you&#39;re not trying to. Even if you aren&#39;t (action: Searching | Search) in exploration mode, you can attempt a check to find environmental hazards that normally require you to (action: Search) for them. You still need to meet any other requirements to find a particular hazard." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("71610432-99cb-48ad-937d-f9052892b346"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c4f9e79-aefb-4d68-84ce-017afb84a0a8"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
