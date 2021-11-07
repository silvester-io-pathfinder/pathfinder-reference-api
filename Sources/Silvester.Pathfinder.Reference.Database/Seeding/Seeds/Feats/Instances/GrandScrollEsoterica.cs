using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrandScrollEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("3bec48f1-fa7a-453b-a739-0042e8f6aa17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grand Scroll Esoterica",
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
            yield return new TextBlock { Id = Guid.Parse("ecc57a8a-5c04-42e3-9ee7-192c3540c156"), Type = TextBlockType.Text, Text = "You’ve completed the third and final step in your assimilation of scroll esoterica, granting you daily scrolls of incredible power. In addition to your daily scrolls from (feat: Scroll Esoterica) and (feat: Elaborate Scroll Esoterica), add a single scroll with a 6th-level spell. At 20th level, add a scroll with a 7th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b3a7aec6-3ef3-42e8-90bf-09d1ccd56d3f"), Feats.Instances.ElaborateScrollEsoterica.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ed081ce-9762-401f-af8d-27bf51dccef9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
