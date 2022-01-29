using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class GiantInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("6a0fda09-c4cf-4a26-849e-24e9cc56d8b7");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Giant Instinct",
                Description = "Your rage gives you the raw power and size of a giant. This doesn't necessarily mean you revere giants'you might scoff at them or even aspire to slay them! You could instead seem like a giant to other people due to your exceptional strength or larger-than-life emotions and ego.",
                Anathema = "Failing to face a personal challenge of strength is anathema.",
                SpecializationAbility = "Increase the damage from Rage when using a larger weapon from 6 to 10; if you have greater weapon specialization, increase it from 10 to 18.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse("7c5b9e79-55aa-4134-b319-3849cf9cd0ca"), InstinctAbilities.Instances.TitanMauler.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("577dfe7e-02cf-4919-a4dd-e7c4939fef4c"), DamageTypes.Instances.Bludgeoning.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);

            builder.AddOr(Guid.Parse("745aa12a-48c6-41a0-b5b5-cc0ac183cbab"), or =>
            {
                or.GainSpecificDamageResistance(Guid.Parse("246c24ae-c337-46e6-a274-35e30f243605"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("dfb6a492-cf64-4ecb-9e4c-8da3796b08e6"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("1f565577-09e9-4df3-9ce5-848bd5584030"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a6c3627-0d58-4bb3-8324-b99f5e155c0a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 87
            };
        }
    }
}
