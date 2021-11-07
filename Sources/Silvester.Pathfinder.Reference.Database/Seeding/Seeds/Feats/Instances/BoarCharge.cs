using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoarCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("67c8c1f9-a0f6-48ac-b6cc-d0fc94639f77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boar Charge",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa55467b-a6fc-433f-ba4a-8cac38c5bc28"), Type = TextBlockType.Text, Text = "The boar (action: Strides | Stride) twice in a straight line and then makes a tusk (action: Strike). As long as it moved at least 20 feet, it gains a +2 circumstance bonus to its attack roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("83f94f21-f690-46b8-b072-25f94d15736f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
