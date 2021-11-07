using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LurchingRush : Template
    {
        public static readonly Guid ID = Guid.Parse("daf99889-d1e6-4019-bb3e-cdaa2519150d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lurching Rush",
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
            yield return new TextBlock { Id = Guid.Parse("7f205347-6f8c-45d2-923d-25a8c32da638"), Type = TextBlockType.Text, Text = "The monitor lizard (action: Strides | Stride) and then makes a jaws (action: Strike). If it moved at least 20 feet away from its starting position, it gains a +2 circumstance bonus to this attack roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a6ad39d-baed-43ce-b3e8-9cc0f3014952"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
