using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WinterCatSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("ca587e4c-e50c-4abd-b42b-ab8287ddebcd");

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
            yield return new TextBlock { Id = Guid.Parse("9ce77beb-8449-4faf-b012-8da44cc226b8"), Type = TextBlockType.Text, Text = $"Your eyes are keen and accustomed to winter conditions. You ignore concealment caused by ice and snow." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("5d25954f-548d-484f-b9ab-6c18c50f862a"), Heritages.Instances.WinterCatfolk.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c04bfaa-fec6-4f81-a148-5ca4b913b431"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
