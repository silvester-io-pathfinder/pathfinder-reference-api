using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class QuakingStomp : Template
    {
        public static readonly Guid ID = Guid.Parse("739ff755-6d1f-49ac-a7ce-85131b3d0ed4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quaking Stomp",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f48bd70b-6c1b-4a32-9291-3ac24b88a7a2"), Type = TextBlockType.Text, Text = "You stomp the ground with such force that it creates a minor earthquake, with the effects of the (spell: earthquake) spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f65143c-f0df-4508-ba86-b094e0c988c3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
