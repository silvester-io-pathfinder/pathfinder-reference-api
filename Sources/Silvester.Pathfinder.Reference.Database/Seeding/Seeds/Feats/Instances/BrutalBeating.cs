using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BrutalBeating : Template
    {
        public static readonly Guid ID = Guid.Parse("b4a1a7e4-eff7-4661-b2e6-531b3c5896d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Brutal Beating",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d00c3249-3eb2-465e-8f9f-b78ece3d3c37"), Type = TextBlockType.Text, Text = "The brutality of your critical hits shakes your foes’ confidence. Whenever your (action: Strike) is a critical hit and deals damage, the target is frightened 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificRacket(Guid.Parse("5c49f5ee-ec03-443a-8cbe-7ada27788ef5"), Rackets.Instances.Ruffian.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27689b76-5abe-4843-b96d-cf7f67d87976"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
