using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PathOfIron : Template
    {
        public static readonly Guid ID = Guid.Parse("768e11c4-4d02-4409-9522-8fb390cd487c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Path of Iron",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0d54c81-0511-48bf-9d04-0bccec6274bc"), Type = TextBlockType.Text, Text = "With a burst of effort, you weave a path through your enemies, striking each in turn as you move past them. You (action: Stride); this movement doesn’t trigger reactions. You can (action: Strike) up to three times at any point during your movement, each against a different enemy. Each attack counts toward your multiple attack penalty, but your multiple attack penalty doesn’t increase until you have made all your attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("867f2354-3532-4056-91eb-b0d77eae0ab2"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cae6bec9-7acb-4fac-af1f-ad3b86367e6d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
