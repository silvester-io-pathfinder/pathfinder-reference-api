using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnlargedChassis : Template
    {
        public static readonly Guid ID = Guid.Parse("8e25c67f-d58c-43ec-9c78-67bda3f04f8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enlarged Chassis",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("73f1a5a4-68c3-4d47-9b08-46f2759da77f"), Type = TextBlockType.Text, Text = "You’ve empowered your core to support a larger body, granting you size and additional reach. You gain the effects of (spell: enlarge) constantly." };
            yield return new TextBlock { Id = Guid.Parse("f5149744-d77a-40b1-8c65-a68d9b1f0b4a"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("62d450eb-7bb4-48ff-92bf-ed4b5660d875"), Type = TextBlockType.Text, Text = "~ Enhancement: Your core’s empowerment has stabilized, allowing for greater support. You are no longer clumsy due to the effects of (spell: enlarge)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("b5c9e2d0-359a-43d7-95ee-83d754b367d6"), or => 
            {
                or.HaveSpecificSize(Guid.Parse("c9b86fc9-aa17-4ada-94cc-fec6fcf0dd16"), AncestrySizes.Instances.Medium.ID);
                or.HaveSpecificSize(Guid.Parse("cabb0208-42c5-4376-9a01-7f1eaee84333"), AncestrySizes.Instances.Small.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("accef908-1276-4907-b1fd-c34f31acfdf8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
