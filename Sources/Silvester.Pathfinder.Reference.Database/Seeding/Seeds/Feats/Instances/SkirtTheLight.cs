using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SkirtTheLight : Template
    {
        public static readonly Guid ID = Guid.Parse("379140be-829d-4b57-adcf-a3dd5fdcfe0b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skirt the Light",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("596cc08c-9018-439f-bb26-b4ad0222585d"), Type = TextBlockType.Text, Text = "You can travel the border between the Material and Shadow Planes and even bring others along. You can cast (spell: shadow walk) as an occult innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("964e31ea-e8de-42db-8fe4-68c7b2c1cec1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
