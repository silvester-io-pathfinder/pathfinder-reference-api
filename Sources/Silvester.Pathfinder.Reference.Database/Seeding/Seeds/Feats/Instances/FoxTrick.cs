using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FoxTrick : Template
    {
        public static readonly Guid ID = Guid.Parse("bb65e61c-f272-4f03-9849-2a211f4e7e71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fox Trick",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95a4abd2-6c41-42b1-b98b-0240121578ed"), Type = TextBlockType.Text, Text = "You always have time for a joke or prank. You (action: Create a Diversion), (action: Conceal an Object), or (action: Hide). All creatures who witnessed your Fox Trick then wise up to it, becoming temporarily immune to your Fox Trick for 24 hours." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0a5d0a7-7149-440c-bd71-f843f52c7c91"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
