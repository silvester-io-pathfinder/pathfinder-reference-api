using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwiftSwimmer : Template
    {
        public static readonly Guid ID = Guid.Parse("99ffa048-eb93-4468-9aa6-74498d669b8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swift Swimmer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6bc0f856-31d9-4f4a-b439-5f32408e5c98"), Type = TextBlockType.Text, Text = "You swim faster than most iruxi. Your swim Speed increases to 25 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("b84a22c5-5b94-4c8b-981f-b7409ff39c09"), Heritages.Instances.WetlanderLizardfolk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("692ade6b-88c8-4e52-b2f6-20d4e733087e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
