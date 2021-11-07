using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThrownVoice : Template
    {
        public static readonly Guid ID = Guid.Parse("8505859f-7224-4068-ae29-d73fa6803f55");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thrown Voice",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c2074085-5a8c-496a-bf78-f60a7078b76b"), Type = TextBlockType.Text, Text = "You’ve learned how to throw your voice through the winds, tricking others as to your location. You can cast (spell: ventriloquism) as a primal innate spell once per day. If you’re a songbird strix, you can cast it twice per day instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4372e494-e292-48d7-882f-8abf1c186d49"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
