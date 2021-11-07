using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingShadows : Template
    {
        public static readonly Guid ID = Guid.Parse("38dfd486-6e75-4df7-98e8-3a48cc5a0862");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Shadows",
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
            yield return new TextBlock { Id = Guid.Parse("2b1c139f-cdcc-4a61-a90d-1f41544421d4"), Type = TextBlockType.Text, Text = "You have learned to remain hidden by using larger folk as a distraction to avoid drawing attention to yourself. You can use creatures that are at least one size larger than you (usually Medium or larger) as cover for the (Action: Hide) and (Action: Sneak) actions, though you still can’t use such creatures as cover for other uses, such as the (Action: Take Cover) action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ee85891-542d-4240-ba86-b65c65d7ce41"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
