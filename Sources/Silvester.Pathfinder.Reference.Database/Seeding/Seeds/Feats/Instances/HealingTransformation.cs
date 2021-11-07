using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("c5ae1d2f-57d9-434c-a128-70fe0dc3667e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Transformation",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("172f83c6-2a34-4147-87ba-2eebfc016c45"), Type = TextBlockType.Text, Text = "You can take advantage of shapechanging magic to close wounds and patch injuries. If your next action is to cast a non-cantrip (trait: polymorph) spell that targets only one creature, your polymorph spell also restores 1d6 Hit Points per spell level to that creature. This is a (trait: healing) effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6c70787-6dd9-4cbf-9e75-528eb9bbc6ff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
