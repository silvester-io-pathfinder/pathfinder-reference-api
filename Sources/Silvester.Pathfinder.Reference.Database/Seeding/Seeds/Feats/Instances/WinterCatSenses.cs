using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WinterCatSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("a9c45995-435a-4ce2-885d-5c2143c4ba40");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Winter Cat Senses",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("491fac2c-ed18-4ae0-b47b-4cdb65883de1"), Type = TextBlockType.Text, Text = "Your eyes are keen and accustomed to winter conditions. You ignore concealment caused by ice and snow." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("4709c354-23a8-4e27-b674-95a4748bbc47"), Heritages.Instances.WinterCatfolk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80b6119c-3c5f-45a6-9ad9-61c1fd4c998c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
