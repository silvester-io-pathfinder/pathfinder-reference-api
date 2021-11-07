using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TimelessBody : Template
    {
        public static readonly Guid ID = Guid.Parse("2c280610-27c1-42d7-970b-6fc223255f1f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Timeless Body",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("302759d3-07a5-40e5-b692-f66af4e6af5f"), Type = TextBlockType.Text, Text = "You cease aging. In addition, you gain a +2 status bonus to saving throws against poisons and diseases, and you gain resistance to poison damage equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb70a972-030c-450f-80ea-840ea3c16a95"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
