using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagpieSnatch : Template
    {
        public static readonly Guid ID = Guid.Parse("880ca82b-a97a-4e82-970d-bf8ddb56fb1a");

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
            yield return new TextBlock { Id = Guid.Parse("24e0d4e7-3eae-42da-a24f-20717ce89097"), Type = TextBlockType.Text, Text = "You move quickly, snatching a shiny item that catches your eye. (action: Stride) twice, and you can (action: Interact) to grab an unattended object at any point during your movement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a1654ac-c2a0-4809-981d-f21a1705caae"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}