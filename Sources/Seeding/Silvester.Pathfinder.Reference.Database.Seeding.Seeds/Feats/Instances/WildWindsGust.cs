using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WildWindsGust : Template
    {
        public static readonly Guid ID = Guid.Parse("a928706f-bab4-4ba8-a825-45be21261fdf");

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
            yield return new TextBlock { Id = Guid.Parse("39291fbb-bad9-4c9b-a5b0-8e18ce65bd1c"), Type = TextBlockType.Text, Text = $"You store up energy and release it in an enormous gust of rushing wind. Make a wind crash {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against each creature in your choice of a 30-foot cone or a 60 foot line. These attacks all count toward your multiple attack penalty, but the penalty doesn't increase until after you make all the attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("321359c3-ac2d-4eff-929a-8c688d879b05"), Feats.Instances.WildWindsInitiate.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("258f880b-ba63-427a-a984-27f5e3b2646d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
