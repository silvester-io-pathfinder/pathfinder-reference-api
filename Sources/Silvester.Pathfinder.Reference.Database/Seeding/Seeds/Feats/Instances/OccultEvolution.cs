using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OccultEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("3e3f8ba3-d961-4d42-b078-737035d5c281");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Occult Evolution",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d2c20e65-0cf5-4c6a-adac-89b4cd6ffc3b"), Type = TextBlockType.Text, Text = "Glimpses of the obscure secrets of the universe loan you power. You become trained in one skill of your choice. Additionally, once per day, you can spend 1 minute to choose one mental occult spell you don’t know and add it to your spell repertoire. You lose this temporary spell the next time you make your daily preparations (though you can use this ability to add it again later)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("cab02fa7-ab1f-408e-b737-61e6665bfef7"), Bloodlines.Instances.Occult..ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92383fa1-e03d-49b2-bdee-3bee048038d2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
