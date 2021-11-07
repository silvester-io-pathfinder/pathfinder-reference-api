using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Regrowth : Template
    {
        public static readonly Guid ID = Guid.Parse("20031498-cc8d-48e6-b1f7-8ad48249ddd5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Regrowth",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4132a1ff-713d-4170-b033-7901e8d6c8a4"), Type = TextBlockType.Text, Text = "Your command over your vital essence allows you or an ally to recover from grievous wounds. You can cast (spell: regenerate) as a 7th-level primal innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43eccdf1-d27c-4150-aa37-fd6ec0d40d3f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
