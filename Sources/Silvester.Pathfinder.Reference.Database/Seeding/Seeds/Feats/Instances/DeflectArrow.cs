using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeflectArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("eaad3dce-95a3-4dfb-9de7-86428ba40746");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deflect Arrow",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are the target of a physical ranged attack.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6b4ea19-cb5f-400a-9a6d-81c92e030f1e"), Type = TextBlockType.Text, Text = "You gain a +4 circumstance bonus to AC against the triggering attack. If the attack misses, you have deflected it. You cannot use this feat to deflect unusually massive ranged projectiles (such as boulders or ballista bolts)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4057eba8-eea4-45d9-a7b7-0e6e46d9dc93"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
