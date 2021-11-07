using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StoneBones : Template
    {
        public static readonly Guid ID = Guid.Parse("8b0fa40d-ec88-44fe-835e-6cc9ffd56034");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stone Bones",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are struck by a critical hit that deals physical damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a106a958-7084-49e9-8103-44590cef89b5"), Type = TextBlockType.Text, Text = "Your intractable nature can help you shrug off even the most grievous injuries. Attempt a DC 17 flat check. If you are successful, the attack becomes a normal hit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2b56a306-fba0-49a4-967a-0965cae91ec4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
