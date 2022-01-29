using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WhirlingKnockdown : Template
    {
        public static readonly Guid ID = Guid.Parse("e17e3a09-1c21-4985-b601-54d0648d98ae");

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
            yield return new TextBlock { Id = Guid.Parse("3a3d85d7-ac13-4f9c-9255-ce02fe59e0b9"), Type = TextBlockType.Text, Text = $"You fire your gun while throwing off a target's balance with your melee weapon. Then, you topple your foe to the ground with the quick orchestrated combination. You don't need to use brute force to do so, or even necessarily to hit with your gunshot; the effect is all about performing perfectly and eliminating your target's movements and options, leaving them no choice but to fall." };
            yield return new TextBlock { Id = Guid.Parse("70774425-3cad-4b62-967b-a17ce895389f"), Type = TextBlockType.Text, Text = $"Make a ranged firearm {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against a creature within the reach of your melee weapon and then attempt a Performance check against the creature's Reflex DC. If the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} critically succeeds, the target takes a –2 circumstance penalty to its Reflex DC against this check. The Performance check has the following effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aeeb9b15-f077-44aa-af2d-6bca1e42c66f"), Feats.Instances.PistolPhenomDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("61b6b63c-d53f-4b71-8e40-37a5a2c866cd"),
                CriticalSuccess = "The target falls and lands prone. It takes 2d6 bludgeoning damage from the fall.",
                Success = "The target falls and lands prone.",
                
                CriticalFailure = "Your plans backfired on you, and you're forced to drop your melee weapon in your space.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4b3eb11-5bc9-44cc-874a-fb001a4cd315"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
