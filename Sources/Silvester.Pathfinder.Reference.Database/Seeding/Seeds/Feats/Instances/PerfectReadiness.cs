using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PerfectReadiness : Template
    {
        public static readonly Guid ID = Guid.Parse("b1bb0005-24e8-484a-8bf0-1cda8e0754b5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Perfect Readiness",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2164a535-05bc-4970-bf64-aee25861912a"), Type = TextBlockType.Text, Text = "You prepare to fire with an instinctive speed and muscle memory that go beyond your conscious thoughts. You’re permanently quickened. You can use your extra action only to (action: Step) or (action: Interact) to reload." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9e1c031-4dbf-4761-ad37-1b9c889516bf"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
