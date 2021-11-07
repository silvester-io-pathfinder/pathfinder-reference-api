using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InfluenceRumor : Template
    {
        public static readonly Guid ID = Guid.Parse("fa3db8c2-14cd-4393-909f-68a6e7cafebe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Influence Rumor",
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
            yield return new TextBlock { Id = Guid.Parse("aef8bd41-e468-4847-a932-d5a9de280e57"), Type = TextBlockType.Text, Text = "You spend at least one day of downtime to manipulate the course, tone, or content of a rumor to your benefit. Attempt a Diplomacy check. The difficulty of Influencing a Rumor is determined by the GM based on the size of the community, the relative perceptiveness of the inhabitants, and the agency of other rumormongers, but it typically starts with at least DC 15 for a small village and increases to at least DC 20 for a town, at least DC 30 for a city, and at least DC 40 for a metropolis." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4568549-7fe5-4b98-b861-db1c15fa00c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
