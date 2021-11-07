using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElaborateScrollEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("c9f62028-6cfb-4b94-8a50-10a466e3b718");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elaborate Scroll Esoterica",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00e2f8dd-220a-4c94-a53f-592265f38f02"), Type = TextBlockType.Text, Text = "Your connection to your scroll esoterica grows stronger, allowing you to create much more powerful scrolls. In addition to your daily scrolls from (feat: Scroll Esoterica), add a scroll with a 3rd-level spell. At 14th level, add a scroll with a 4th-level spell. At 16th level, add a scroll with a 5th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7519a7e7-e9f3-4c4f-9377-737ac4330695"), Feats.Instances.ScrollEsoterica.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d26475d-2cd6-459d-89f7-02b350f422fe"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
