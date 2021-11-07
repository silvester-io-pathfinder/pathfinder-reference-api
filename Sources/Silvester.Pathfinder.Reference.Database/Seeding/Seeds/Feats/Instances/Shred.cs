using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Shred : Template
    {
        public static readonly Guid ID = Guid.Parse("686a1e96-e9ec-44a8-9c33-e56071a0f8ba");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shred",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bc40778-e29f-40d8-9f93-cd7abde3bb64"), Type = TextBlockType.Text, Text = "The shark viciously rips into the wound, dealing additional damage. The target of the shark’s (action: Strike) takes 1d8 slashing damage (2d8 for a mature shark or 3d8 for a specialized companion)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85e6e53a-00cb-49ac-9b90-496bce7eed66"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
