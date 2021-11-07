using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReturnFire : Template
    {
        public static readonly Guid ID = Guid.Parse("386a9268-d578-44e1-beb1-e0c6ec4060ab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Return Fire",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f006736-f9d5-4dd8-82a5-adc78ba70d64"), Type = TextBlockType.Text, Text = "Snatching an arrow out of the air, you instantly put it to your bow and return fire. When you successfully (feat: Deflect an Arrow | Deflect Arrow), as part of that reaction you can immediately make a ranged bow (action: Strike) by firing the arrow you deflected from your own bow." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c41d976d-f68a-4289-9428-0f4b9b3abb92"), Feats.Instances.DeflectArrow.ID);
            builder.HaveSpecificFeat(Guid.Parse("d2fc1229-2462-4b9e-b5de-e4a367d74cad"), Feats.Instances.MonasticArcherStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fe27124-6fa4-4652-aee4-146d5637c997"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
