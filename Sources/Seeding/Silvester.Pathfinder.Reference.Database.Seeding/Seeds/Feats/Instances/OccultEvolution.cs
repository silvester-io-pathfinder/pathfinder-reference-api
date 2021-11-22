using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OccultEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("44cb990b-2acb-414c-8b43-1f06303f91c6");

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
            yield return new TextBlock { Id = Guid.Parse("9ab2ca54-c6d4-4976-8db9-d963d5fbf464"), Type = TextBlockType.Text, Text = "Glimpses of the obscure secrets of the universe loan you power. You become trained in one skill of your choice. Additionally, once per day, you can spend 1 minute to choose one mental occult spell you don't know and add it to your spell repertoire. You lose this temporary spell the next time you make your daily preparations (though you can use this ability to add it again later)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("73d52264-62c2-41b7-87c8-a8447ddbe86f"), MagicTraditions.Instances.Occult.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44f10aaa-a6c9-45a3-b847-a719037cbe61"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
