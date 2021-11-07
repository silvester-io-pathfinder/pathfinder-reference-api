using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeflectArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("ac1ac80c-0952-4b55-834d-dd2fb3c32ea4");

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
            yield return new TextBlock { Id = Guid.Parse("bc3a533e-3429-48e5-a6eb-cfed83994784"), Type = TextBlockType.Text, Text = "You gain a +4 circumstance bonus to AC against the triggering attack. If the attack misses, you have deflected it. You cannot use this feat to deflect unusually massive ranged projectiles (such as boulders or ballista bolts)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2165d660-6efa-4e64-9cc9-75f1ab3bb3ab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
