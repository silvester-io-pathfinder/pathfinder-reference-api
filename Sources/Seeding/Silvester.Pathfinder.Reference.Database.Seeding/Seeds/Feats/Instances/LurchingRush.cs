using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LurchingRush : Template
    {
        public static readonly Guid ID = Guid.Parse("11f14f58-53aa-440b-a6be-7aea9b85a692");

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
            yield return new TextBlock { Id = Guid.Parse("7325e2f9-b93d-4dc5-bb01-e236076f5fdf"), Type = TextBlockType.Text, Text = "The monitor lizard (action: Strides | Stride) and then makes a jaws (action: Strike). If it moved at least 20 feet away from its starting position, it gains a +2 circumstance bonus to this attack roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("74a2a43d-a7d4-4c82-aca7-bad40fb09d7c"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
