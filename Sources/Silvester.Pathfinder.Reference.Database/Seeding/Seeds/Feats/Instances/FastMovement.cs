using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FastMovement : Template
    {
        public static readonly Guid ID = Guid.Parse("f3a43244-aa23-49b2-b3ac-ec25d432eb70");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fast Movement",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7255497e-17a3-48a0-8f2d-32449c78ca56"), Type = TextBlockType.Text, Text = "Your rage is a frenzy of rapid movements. While you are raging, you gain a +10-foot status bonus to your Speed." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbc90d53-92dc-4ef4-8d21-4d81668a3689"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
