using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdditionalShadowMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("705856ec-b467-4301-a73b-acec8ed103a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Shadow Magic",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ba29bae-da2b-4f74-8906-197cd165f88e"), Type = TextBlockType.Text, Text = "Choose an additional shadowcaster focus spell you haven’t already selected from (feat: Shadow Magic). Increase the number of Focus Points in your pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9cef05ce-a11a-46a9-bde7-d8fd88cdfd5e"), Feats.Instances.ShadowMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06f30072-d552-46c4-9dd9-1b8275690133"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
