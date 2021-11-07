using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SchoolOfPerfectionUntwistingIron : Template
    {
        public static readonly Guid ID = Guid.Parse("a8b196c1-029f-49d0-842e-52d1c452b91d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "School of Perfection - Untwisting Iron",
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
            yield return new TextBlock { Id = Guid.Parse("a7ac8a3e-f587-41d2-ae64-8835c827862f"), Type = TextBlockType.Text, Text = "You gain the (spell: untwisting iron buffer) ki spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ca4aae3-1182-44f6-a6f2-913ee0d3f20d"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
