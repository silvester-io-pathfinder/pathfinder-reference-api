using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerpetualScout : Template
    {
        public static readonly Guid ID = Guid.Parse("fbf985dd-bdb2-4284-b376-535981fdcbe5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perpetual Scout",
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
            yield return new TextBlock { Id = Guid.Parse("c54ed5f6-4815-4deb-ab85-746569718d47"), Type = TextBlockType.Text, Text = "You spot anything out of place in the areas you know best. While in your favored terrain, you always gain the benefits of the (action: Scout) exploration activity, even if you are performing another exploration activity. If you’re legendary in Survival, you gain these benefits in any terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa81310c-70f9-4dd4-9516-3e7360065f9e"), Feats.Instances.HorizonWalkerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e000d720-ff91-4420-b09d-0f432293796e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
