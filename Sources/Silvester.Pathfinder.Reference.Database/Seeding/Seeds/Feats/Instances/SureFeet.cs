using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SureFeet : Template
    {
        public static readonly Guid ID = Guid.Parse("18939d57-8311-4235-950c-79c00dd49a4e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sure Feet",
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
            yield return new TextBlock { Id = Guid.Parse("9d651f13-b288-414a-875c-e335cd43d27c"), Type = TextBlockType.Text, Text = "Whether keeping your balance or scrambling up a tricky climb, your hairy, calloused feet easily find purchase. If you roll a success on an Acrobatics check to (Action: Balance) or an Athletics check to (Action: Climb), you get a critical success instead. You’re not flat-footed when you attempt to (Action: Balance) or (Action: Climb)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63a05ff4-3414-48a9-9d2e-b6096b1c25e5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
