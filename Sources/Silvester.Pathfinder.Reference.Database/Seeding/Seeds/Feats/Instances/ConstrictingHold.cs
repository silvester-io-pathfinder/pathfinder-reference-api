using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstrictingHold : Template
    {
        public static readonly Guid ID = Guid.Parse("159b03c4-6f6a-4021-9ef3-8aeb98aac533");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Constricting Hold",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f29f37a8-fd29-4c74-b109-3dace3ef7eb5"), Type = TextBlockType.Text, Text = "Your eidolon constricts the creature, dealing bludgeoning damage equal to your eidolon’s level plus its Strength modifier, with a basic Fortitude save against your spell DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fc0cdb1-4977-4bed-b04a-f9dda52b84b2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
