using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualbornFire : Template
    {
        public static readonly Guid ID = Guid.Parse("06b8eb0c-416f-46fd-ad04-05fa913f102b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dualborn - Fire",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("68c89bb1-43d1-40ed-ae02-196168c91961"), Type = TextBlockType.Text, Text = "You gain resistance equal to half your level (minimum 1) to all damaging effects with the (trait: fire) trait." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3189368-5504-4175-965a-e43ceb0536e9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
