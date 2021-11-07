using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildWindsGust : Template
    {
        public static readonly Guid ID = Guid.Parse("519bae7e-a9be-4395-b1e3-cad3e12bf662");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wild Winds Gust",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13bf3c43-d57b-4ee3-9a97-4e8cb6b04dac"), Type = TextBlockType.Text, Text = "You store up energy and release it in an enormous gust of rushing wind. Make a wind crash (action: Strike) against each creature in your choice of a 30-foot cone or a 60 foot line. These attacks all count toward your multiple attack penalty, but the penalty doesn’t increase until after you make all the attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1714d7a6-1a1a-46a2-a8e5-5d44b12bb2f7"), Feats.Instances.WildWindsInitiate.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("499b8995-5f94-4d35-b1d4-2648eb137fb4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
