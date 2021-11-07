using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseThoughts : Template
    {
        public static readonly Guid ID = Guid.Parse("fe0e6b19-f439-41ac-954b-4339375c60f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense Thoughts",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d93cb40-82e7-4bcb-87db-6ea979f6c7b3"), Type = TextBlockType.Text, Text = "You have an even stranger knack for knowing what other people are thinking. You can cast (spell: mind reading) as an innate occult spell once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38faae1b-bb71-47cd-b3f8-bdba23d25cf8"), Feats.Instances.ShareThoughts.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5bc57a1d-de0b-4610-897c-58d570fbb618"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
