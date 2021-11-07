using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArdentArmiger : Template
    {
        public static readonly Guid ID = Guid.Parse("e921448a-e8d3-4096-8a06-dac6455b1f80");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ardent Armiger",
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
            yield return new TextBlock { Id = Guid.Parse("d9ab8fd6-e0f3-4271-8cc5-cb86b0328002"), Type = TextBlockType.Text, Text = "You have been trained to resist the manipulations of fiends, and your Hellknight discipline makes you difficult to influence. You gain a +1 circumstance bonus to saves against (trait: mental) effects that specifically improve your attitude and to your Will DC against someone (action: Coercing | Coerce) you, (action: Demoralizing | Demoralize) you, (action: Making an Impression | Make an Impression) on you, or making a (action: Request) of you." };
            yield return new TextBlock { Id = Guid.Parse("68109e6b-4405-47eb-9fab-3921d520af50"), Type = TextBlockType.Text, Text = "If a (trait: mental) effect would compel you to act in a way that violates your Hellknight order’s tenets (as determined by the GM), you can attempt to break free from the effect as a reaction triggered by receiving the violating order, and you gain a new Will save against the effect. You can attempt this new save only once for a given effect, even if you are compelled to violate your order’s tenets multiple times." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("820d539c-fda9-4ad4-963e-c1391a80efd1"), Feats.Instances.HellknightArmigerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fef0fe5-66bd-449c-847e-e658c5a119b0"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
