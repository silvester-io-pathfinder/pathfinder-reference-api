using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefianceUntoDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("ac048549-4651-44a9-8ec8-fff761b067a6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defiance Unto Death",
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
            yield return new TextBlock { Id = Guid.Parse("526ecc28-c29d-41ea-bff8-016b9098337a"), Type = TextBlockType.Text, Text = "~ Access: Spiresworn elf" };
            yield return new TextBlock { Id = Guid.Parse("912ff25b-7245-4ad4-b0c1-d114911dce81"), Type = TextBlockType.Text, Text = "You loathe the alghollthus and their mind magic, and you’ve been trained to be willing to die rather than give into mental manipulation. If you would start your turn confused, controlled, or fleeing due to a failed Will save, you can attempt a Will save against the same DC; on a success, you become paralyzed until your next turn, rather than act against your will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f985ae0-2825-45f8-b8f0-9611a636656d"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
