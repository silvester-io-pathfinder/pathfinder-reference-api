using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IllusionSense : Template
    {
        public static readonly Guid ID = Guid.Parse("111c9ea2-d14d-4889-9e23-2a99d0fd4942");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Illusion Sense",
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
            yield return new TextBlock { Id = Guid.Parse("eae40335-e223-411c-a9e9-af342dc55d30"), Type = TextBlockType.Text, Text = "Your ancestors spent their days cloaked and cradled in illusions, and as a result, sensing illusion magic is second nature to you. You gain a +1 circumstance bonus to both Perception checks and Will saves against illusions." };
            yield return new TextBlock { Id = Guid.Parse("4138096f-fcdd-47cc-b006-2cfc7b5d335b"), Type = TextBlockType.Text, Text = "When you come within 10 feet of an illusion that can be disbelieved, the GM rolls a secret check for you to disbelieve it, even if you didn’t spend an action to (action: Interact) with the illusion." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("607ec7fc-0e4b-4979-bc68-c09db57905c1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
