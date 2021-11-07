using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Emotionless : Template
    {
        public static readonly Guid ID = Guid.Parse("8f10b83a-6fb2-4794-90b8-771b6331e747");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emotionless",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e64f3b21-bb05-46d5-8167-b6f5f29a6093"), Type = TextBlockType.Text, Text = "Your malfunctioning emotional processors make it difficult for you to feel strong emotions. You gain a +1 circumstance bonus to saving throws against (trait: emotion) and (trait: fear) effects. If you roll a success on a saving throw against an (trait: emotion) or (trait: fear) effect, you get a critical success instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07dda4b1-a156-4e18-a223-4867ff7a55ab"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
