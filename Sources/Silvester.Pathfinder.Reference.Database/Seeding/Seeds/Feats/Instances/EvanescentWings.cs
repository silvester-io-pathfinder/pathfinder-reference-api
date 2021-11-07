using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EvanescentWings : Template
    {
        public static readonly Guid ID = Guid.Parse("f0fc2ff8-fc0e-4ca0-97fe-fe93c6cc1b06");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Evanescent Wings",
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
            yield return new TextBlock { Id = Guid.Parse("7faed15c-bb5f-4ff8-99ff-804a53fcebcf"), Type = TextBlockType.Text, Text = "You’ve manifested wings that can flutter for brief spurts. You don’t need to spend any additional actions to reach something in your space that a Medium creature could reach. For instance, if you wanted to open a cookie jar located four feet off the ground, you only need to spend a single (action: Interact) action to do so. When you use Evanescent Wings to flutter to a higher place in your space, your action gains the (trait: move) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("24258393-ecab-4387-8e44-ad19fe18ea2c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
