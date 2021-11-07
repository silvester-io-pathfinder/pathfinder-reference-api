using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Scamper : Template
    {
        public static readonly Guid ID = Guid.Parse("c53ed95f-034e-4d1b-ad67-fe94af246bc5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scamper",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9a36b5d-ac06-4493-90dd-df9f2e496b2e"), Type = TextBlockType.Text, Text = "You instinctively know how to flee danger. You (action: Stride) up to your Speed, with a +5-foot status bonus to your Speed, and you gain a +2 circumstance bonus to AC against reactions triggered by this movement. You must end this movement in a space that&#39;s not adjacent to any enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eae3e145-db37-4b21-aee8-96aca1602386"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
