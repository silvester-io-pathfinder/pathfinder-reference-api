using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VerySneaky : Template
    {
        public static readonly Guid ID = Guid.Parse("82aaa4cb-01d4-46a6-842b-05d8d5bd37c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Very Sneaky",
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
            yield return new TextBlock { Id = Guid.Parse("9d8b2d5c-d60c-4fb8-834e-9da02cf989a4"), Type = TextBlockType.Text, Text = "Taller folk rarely pay attention to the shadows at their feet, and you take full advantage of this. You can move 5 feet farther when you take the (action: Sneak) action, up to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("22b56133-ef3d-4faf-b875-be08bf02fcd1"), Type = TextBlockType.Text, Text = "In addition, as long as you continue to use (action: Sneak) actions and succeed at your Stealth check, you don’t become observed if you don’t have cover or greater cover and aren’t concealed at the end of the (action: Sneak) action, as long as you have cover or greater cover or are concealed at the end of your turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e0cacce-917a-403d-b0c9-5a8a4e31b879"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
