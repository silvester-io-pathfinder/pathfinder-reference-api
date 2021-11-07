using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NeverTire : Template
    {
        public static readonly Guid ID = Guid.Parse("632b1964-19ff-40d7-bd87-324bc3d29e45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Never Tire",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would gain the fatigued condition.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b221438-7b45-427f-900e-ddf8abe3f26c"), Type = TextBlockType.Text, Text = "As long as you have an audience, you can continue to perform. Indeed, you must – you have an obligation to your fans! You delay the effects of the fatigued condition for 1 minute or until you are no longer observed by the required creatures, whichever comes first. If the fatigued condition has a duration, the duration begins to elapse only after the delay. You can’t further delay or prevent the fatigued condition after this ability ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5d4a4a11-7d76-40d8-aadd-6323393f5b09"), Feats.Instances.CelebrityDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a506fc4-bf21-4151-a3d3-7e547f7b0dcf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
