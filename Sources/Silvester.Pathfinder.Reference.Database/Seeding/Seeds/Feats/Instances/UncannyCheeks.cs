using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannyCheeks : Template
    {
        public static readonly Guid ID = Guid.Parse("6010043d-63ea-49d3-9125-95e3bc60eb53");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Cheeks",
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
            yield return new TextBlock { Id = Guid.Parse("04e78980-1d41-483a-a864-62fecca58ae6"), Type = TextBlockType.Text, Text = "You squirrel away useful objects and seem to retrieve them at just the right time. You gain the (feat: Prescient Consumable) and (feat: Prescient Planner) feats, except that you always withdraw the objects from your cheek pouches. This means the object you retrieve must fit in your cheek pouches; this is generally an item of negligible Bulk unless you also have the (feat: Cheek Pouches) feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d8e8803-6042-481b-a125-1642fdea0dc0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
