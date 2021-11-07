using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlingKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("da087f30-4789-4418-93f0-ad37469b1d6b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Whirling Knockdown",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db51027e-404c-4475-96f8-26bb8a759096"), Type = TextBlockType.Text, Text = "You fire your gun while throwing off a target’s balance with your melee weapon. Then, you topple your foe to the ground with the quick orchestrated combination. You don’t need to use brute force to do so, or even necessarily to hit with your gunshot; the effect is all about performing perfectly and eliminating your target’s movements and options, leaving them no choice but to fall." };
            yield return new TextBlock { Id = Guid.Parse("1a5d1de3-54f1-4911-8866-e26b298170ef"), Type = TextBlockType.Text, Text = "Make a ranged firearm (action: Strike) against a creature within the reach of your melee weapon and then attempt a Performance check against the creature’s Reflex DC. If the (action: Strike) critically succeeds, the target takes a –2 circumstance penalty to its Reflex DC against this check. The Performance check has the following effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("744dfc26-2eb6-46d4-aafd-07b9222a0efb"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("b8ed81be-36e2-4a7c-85c8-22a002b49f72"),
                CriticalSuccess = "The target falls and lands prone. It takes 2d6 bludgeoning damage from the fall.",
                Success = "The target falls and lands prone.",
                
                CriticalFailure = "Your plans backfired on you, and you’re forced to drop your melee weapon in your space.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5059792-6938-4b86-bc4e-3432e88fe68c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
