using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SureFeet : Template
    {
        public static readonly Guid ID = Guid.Parse("c7bfbb53-4ae2-4c56-a619-6a7c23ab8344");

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
            yield return new TextBlock { Id = Guid.Parse("267b0a28-8640-4674-bc36-137ffbc5b33e"), Type = TextBlockType.Text, Text = "Whether keeping your balance or scrambling up a tricky climb, your hairy, calloused feet easily find purchase. If you roll a success on an Acrobatics check to (Action: Balance) or an Athletics check to (Action: Climb), you get a critical success instead. You're not flat-footed when you attempt to (Action: Balance) or (Action: Climb)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f4f9c5b-b31f-45cf-ae84-03a734722c9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
