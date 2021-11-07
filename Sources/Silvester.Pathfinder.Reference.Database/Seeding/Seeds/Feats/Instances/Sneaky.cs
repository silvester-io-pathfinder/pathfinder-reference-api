using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Sneaky : Template
    {
        public static readonly Guid ID = Guid.Parse("decc388c-164f-401d-aecf-299612cdfa30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sneaky",
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
            yield return new TextBlock { Id = Guid.Parse("1190b6e3-5226-40c8-b7d3-5dec85559903"), Type = TextBlockType.Text, Text = "Stealth is an important tool in your arsenal. You can move 5 feet farther when you take the (action: Sneak) action, up to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("08018f6f-a6ef-46e1-a03f-30aa6c9ee0e7"), Type = TextBlockType.Text, Text = "In addition, as long as you continue to use Sneak actions and succeed at your Stealth check, you don’t become observed if you don’t have cover or greater cover and aren’t concealed at the end of the (action: Sneak) action, as long as you have cover or greater cover or are concealed at the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("423f4993-7af8-40bc-9593-b4d37f76852f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
