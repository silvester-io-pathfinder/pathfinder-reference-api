using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SoaringDynamo : Template
    {
        public static readonly Guid ID = Guid.Parse("ab8a539a-5096-4d68-a5d0-ee51eb08a5e7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Soaring Dynamo",
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
            yield return new TextBlock { Id = Guid.Parse("bbac8a45-61b7-4da4-8ed5-16a42a7dde09"), Type = TextBlockType.Text, Text = "You’ve built clockwork wings or jets into your dynamo, allowing you to use your prosthesis to fly. You gain a fly Speed equal to your Speed. Each minute of flight reduces the operational time of your sterling dynamo by 1 hour, measured from the first time you use the (action: Fly) action in a given minute." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c9e66353-a185-46f2-98d1-746c57d59e3f"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a672178-1dc4-41cd-afdd-ddbf5b6a6ffa"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
