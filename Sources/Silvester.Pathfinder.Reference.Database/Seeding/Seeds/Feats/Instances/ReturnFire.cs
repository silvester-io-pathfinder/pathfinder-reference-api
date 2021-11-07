using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReturnFire : Template
    {
        public static readonly Guid ID = Guid.Parse("76a7d7d3-da48-4b5a-972e-13ce5d090e26");

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
            yield return new TextBlock { Id = Guid.Parse("bc41beaf-a631-4620-9a27-e19618859aa8"), Type = TextBlockType.Text, Text = "Snatching an arrow out of the air, you instantly put it to your bow and return fire. When you successfully (feat: Deflect an Arrow | Deflect Arrow), as part of that reaction you can immediately make a ranged bow (action: Strike) by firing the arrow you deflected from your own bow." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("53178b2d-d2ed-4094-898d-c3a83fc002bb"), Feats.Instances.DeflectArrow.ID);
            builder.HaveSpecificFeat(Guid.Parse("f877f867-c453-4d49-b98a-2b2a8cdd6afe"), Feats.Instances.MonasticArcherStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("706ad655-7d11-461e-9135-0c4b2e3a00d2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
