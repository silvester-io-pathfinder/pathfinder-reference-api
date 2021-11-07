using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImplementsFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("f6d9a833-0e88-40f3-8dd7-2f5d7e19cd35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Implement's Flight",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3a2e851-1e2d-43af-be8f-fd87807716f9"), Type = TextBlockType.Text, Text = "By weakening your connection to the ground and strengthening your connection to the sky, you’ve learned to soar through the air, your implement carrying you as surely as any broomstick or pestle. As long as you’re holding your implement, you gain a fly Speed equal to your land Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d1d8ac9-25eb-4d5c-af3c-0cc4e6ca8f75"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
