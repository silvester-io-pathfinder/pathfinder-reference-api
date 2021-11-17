using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UltimateFlexibility : Template
    {
        public static readonly Guid ID = Guid.Parse("0e096d35-00fa-44a8-bffb-158d36e5cf4e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ultimate Flexibility",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("870b6138-44f6-4fc9-8b61-f79fb69adbc3"), Type = TextBlockType.Text, Text = "Your experience keeps you on your toes, making you adaptable to even the most dangerous challenges. When you gain a fighter feat using combat flexibility, you gain three fighter feats instead of two. While the first feat must still be 8th level or lower, the second feat can be up to 14th level, and the third feat can be up to 18th level. You can use the first feat to meet the prerequisites of the second or third feats and the second feat to meet the prerequisites of the third feat. You must meet all feats’ prerequisites. In addition, you can adapt to the battlefield’s challenges by spending 1 hour to train. If you do, you can reselect the feats chosen with combat flexibility as if you had made your daily preparations. You can’t trade out limited-use abilities that you’ve already used, such as (feat: Determination)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("cc776f3f-ac7e-4702-bc16-3071b89988b7"), ClassFeatures.Fighters.ImprovedFlexibility.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1409c91-8bc7-4588-90c3-643903d6e242"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
