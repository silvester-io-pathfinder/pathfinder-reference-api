using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuidingFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("11df38ad-93cd-4443-8403-e99581db9074");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guiding Finish",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7587c15b-d04f-4743-87a8-041e3ac82371"), Type = TextBlockType.Text, Text = "Using your weapon as a lever, you force your opponent to end up right where you want them. Make a (Action: Strike) with the required weapon. If the (Action: Strike) hits, you can move the target up to 10 feet into a space in your reach." };
            yield return new TextBlock { Id = Guid.Parse("09f28867-9ac4-42c1-b24c-6e7ca05e771e"), Type = TextBlockType.Text, Text = "You can move the target through your space during this movement. This follows the forced movement rules found on page 475. Your (Action: Strike) gains the following failure effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ca229128-8252-43da-a43a-ee03db54c241"),
                
                
                Failure = "You can force the creature to move as you would on a success, but you can move the target only 5 feet.",
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2d673fa4-718c-45a5-8286-7cf1c8264508"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
