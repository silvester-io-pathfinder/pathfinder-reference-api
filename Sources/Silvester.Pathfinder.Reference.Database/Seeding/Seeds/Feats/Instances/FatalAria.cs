using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FatalAria : Template
    {
        public static readonly Guid ID = Guid.Parse("f0afd5e3-8e96-4698-b372-51c646f47570");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fatal Aria",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f8db6d2-0da8-4b8a-b008-06193a25a089"), Type = TextBlockType.Text, Text = "Your songs overwhelm the target with unbearable emotion, potentially striking them dead on the spot. You learn the (spell: fatal aria) composition spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e19b62cd-f041-4f9d-a723-7e5c9bd961e5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
