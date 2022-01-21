using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElaborateScrollEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("ce0dd072-ad75-435a-a247-b2c75fd65a82");

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
            yield return new TextBlock { Id = Guid.Parse("bce937f3-d151-4c74-bd8f-be3105210f67"), Type = TextBlockType.Text, Text = $"Your connection to your scroll esoterica grows stronger, allowing you to create much more powerful scrolls. In addition to your daily scrolls from {ToMarkdownLink<Models.Entities.Feat>("Scroll Esoterica", Feats.Instances.ScrollEsoterica.ID)}, add a scroll with a 3rd-level spell. At 14th level, add a scroll with a 4th-level spell. At 16th level, add a scroll with a 5th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c10cc061-1247-4e03-9c09-966b737091de"), Feats.Instances.ScrollEsoterica.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("599d4692-893f-4567-a53a-93dd860daa6e"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
