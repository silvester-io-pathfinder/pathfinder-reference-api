using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StasianSmash : Template
    {
        public static readonly Guid ID = Guid.Parse("34fb4e74-8dca-4aca-a88a-b47323f920dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stasian Smash",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b936ee4-efab-4770-a8a3-4a3191c34c97"), Type = TextBlockType.Text, Text = "~ Access: You are from Ustalav." };
            yield return new TextBlock { Id = Guid.Parse("febc07eb-2e25-4e9c-87dc-b839f8e057eb"), Type = TextBlockType.Text, Text = "You’ve modified your dynamo with Stasian coils, allowing you to make a powerful attack that crackles with electricity. Make a dynamo (action: Strike). On a success, the (action: Strike) deals an additional 1d12 electricity damage to the target, as well as 1d4 electricity damage to up to two other foes within 10 feet as sparks leap across the gaps. If you critically fail your dynamo (action: Strike), you take 1d12 electricity damage. This counts as two attacks when calculating your multiple attack penalty. At 18th level, the additional electricity damage to the target increases to 2d12, and the additional electricity damage to the other foes increases to 2d4. Reduce the operational time of your sterling dynamo by 1 hour." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3d870160-dc31-4b5b-bd73-213cea72aa51"), Feats.Instances.SterlingDynamoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f036b705-19d3-4561-a2d8-d3148174b288"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
