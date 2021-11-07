using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GuardedMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("9d2fb338-f4b8-4fab-beb1-e64dc87ccf5c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guarded Movement",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec513642-e042-4af1-bea2-a8d37aeb9363"), Type = TextBlockType.Text, Text = "Your guard is up, even while moving. You gain a +4 circumstance bonus to AC against reactions triggered by your movement." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c73b8e5-d490-4944-a211-07e469e71457"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
