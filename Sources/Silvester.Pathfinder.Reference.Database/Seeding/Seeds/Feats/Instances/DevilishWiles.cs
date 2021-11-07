using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevilishWiles : Template
    {
        public static readonly Guid ID = Guid.Parse("382aae79-a42d-478d-a847-5a16a6d98858");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devilish Wiles",
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
            yield return new TextBlock { Id = Guid.Parse("6b1c02a6-a38c-4293-9312-64122bce1dd7"), Type = TextBlockType.Text, Text = "Traditionally, fiends are exceptionally good at persuading people to do things, even when their targets know it’s a bad idea. You’re also rather good at it, compelling the weak and weak-willed to your bidding. You can cast (spell: charm) once per day as a 1st-level divine innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1a2ef35-d3b8-41a7-bc7f-b0568ff5bc1b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
