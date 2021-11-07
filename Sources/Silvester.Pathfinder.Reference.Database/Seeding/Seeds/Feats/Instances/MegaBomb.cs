using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MegaBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("1f3c2796-0411-497a-91e8-3570ea647b3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mega Bomb",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are holding an infused alchemical bomb you crafted, with a level at least 3 lower than your Advanced Alchemy level.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d2389c2-fcf2-438e-b27c-0fffcb5e9454"), Type = TextBlockType.Text, Text = "You add an incredibly powerful additive to a held bomb to create a mega bomb, greatly increasing its area and power. You use an (action: Interact) action to throw the mega bomb, rather than (action: Strike), and you don’t make an attack roll. The mega bomb affects creatures in a 30-foot-radius burst, centered within 60 feet of you. The bomb deals damage as if each creature were the primary target, with a basic Reflex save. On a failed save, a creature also takes any extra effects that affect a primary target (such as flat-footed from bottled lightning). While all targets in the area take splash damage as primary targets, there is no further splash beyond that area. If your next action after creating a mega bomb isn’t an (action: Interact) action to throw it, the mega bomb denatures and loses all effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c9761da1-47c7-4313-80cd-b9ec469ec650"), Feats.Instances.ExpandedSplash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8201c39-6e47-4e60-99e4-9e1e34fe3697"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
