using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CannyAcumenReflex : Template
    {
        public static readonly Guid ID = Guid.Parse("6a3f9f3b-2c42-4011-94b8-edcab12018b6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Canny Acumen - Reflex",
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
            yield return new TextBlock { Id = Guid.Parse("55281d77-12c8-4bbc-94e5-e58df350579a"), Type = TextBlockType.Text, Text = "You become an expert in Reflex saves. At 17th level, you become a master instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("652d3fd0-013a-4e3d-8c22-a51bebec2cc2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
