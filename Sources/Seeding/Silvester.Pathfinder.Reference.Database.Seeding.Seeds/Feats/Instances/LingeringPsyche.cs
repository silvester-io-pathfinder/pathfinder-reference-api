using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LingeringPsyche : Template
    {
        public static readonly Guid ID = Guid.Parse("9cb6a0d8-3185-48a8-8748-0f521dc60f73");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lingering Psyche",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d038012-b914-42d1-9dd2-30f61227967a"), Type = TextBlockType.Text, Text = $"When you Unleash your psyche, you can remain in that state longer before leaving it. Increase the duration of your psyche to 5 rounds." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae761c2e-3328-42aa-88c1-96f3db319eb0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
