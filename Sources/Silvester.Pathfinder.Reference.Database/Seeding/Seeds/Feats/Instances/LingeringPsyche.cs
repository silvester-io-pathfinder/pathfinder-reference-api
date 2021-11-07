using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LingeringPsyche : Template
    {
        public static readonly Guid ID = Guid.Parse("383654c7-16b9-4c26-a51b-9117d2e0a896");

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
            yield return new TextBlock { Id = Guid.Parse("69d9fad1-1c9f-4c5b-8abf-478af1e6e67e"), Type = TextBlockType.Text, Text = "When you Unleash your psyche, you can remain in that state longer before leaving it. Increase the duration of your psyche to 5 rounds." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd0574c1-5bfc-423b-9903-3f587df670d8"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
