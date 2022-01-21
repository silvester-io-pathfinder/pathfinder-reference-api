using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeepestWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("ba92606d-f226-4737-8e29-7906a2207215");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deepest Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f8a8a8f7-36bc-4e28-b964-03db88f2dd3b"), Type = TextBlockType.Text, Text = $"You've traveled to the furthest depths of your subconscious, granting you even more focus. Increase the number of Focus Points in your focus pool by 1. If you've spent at least 3 Focus Points since the last time you {ToMarkdownLink<Models.Entities.Activity>("Refocused", Activities.Instances.Refocus.ID)}, you recover 3 Focus Points when you {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} instead of 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("624ee85f-0586-4436-a8cc-3bd1f748dfbc"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
