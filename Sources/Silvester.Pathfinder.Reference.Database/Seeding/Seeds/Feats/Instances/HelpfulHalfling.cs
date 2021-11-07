using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HelpfulHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("d9662793-1333-4798-93b9-66c9579ea174");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Helpful Halfling",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("197fed1d-34df-4d4f-85cc-6cfe742f9b80"), Type = TextBlockType.Text, Text = "When you aid a friend with a task, you find many ways to help and avoid interfering. On a critical success to (action: Aid), you grant your ally a +3 circumstance bonus if you have expert proficiency in the skill (rather than +2), and you grant your ally a +4 circumstance bonus if you have master proficiency (rather than +3). If you roll a critical failure on a check to (action: Aid), you don’t give your ally a -1 circumstance penalty to their check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5c9c8f0-c468-4f68-9862-c18c17ce4d94"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
