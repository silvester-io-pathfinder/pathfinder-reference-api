using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagpieSnatch : Template
    {
        public static readonly Guid ID = Guid.Parse("d8446b5f-318a-423d-92f3-c34d47528ecb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magpie Snatch",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ff5d0df-9716-40c7-8851-59c4a64388fb"), Type = TextBlockType.Text, Text = "You move quickly, snatching a shiny item that catches your eye. (action: Stride) twice, and you can (action: Interact) to grab an unattended object at any point during your movement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1daba527-6a97-4e02-860f-042ebd5279f5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
