using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplendidCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("a4603168-f1b5-4b4b-bcb5-124958234865");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Splendid Companion",
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
            yield return new TextBlock { Id = Guid.Parse("0d998cc9-e15c-4ac3-b0e4-4ff78c25274b"), Type = TextBlockType.Text, Text = "Your animal companion continues to develop. It becomes a nimble or savage animal companion (your choice), gaining abilities determined by its type. Increase its proficiency rank in Performance to master instead of Athletics or Acrobatics." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8ae10090-8752-43bf-914a-e1b161d70cc6"), Feats.Instances.MatureTrainedCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f31f30e-d9ac-4e9d-aa11-56df1798cafc"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
