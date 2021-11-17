using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class SpiritInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("dc4cc6d6-dfa7-4ab3-97b1-98652521c1d1");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Spirit Instinct",
                Description = "Whether you are emotionally sensitive to the spirits around you; worship ancestors or apparitions; or are haunted by the specter of an ancestor, relative, friend, or foe, your rage takes the form of a spiritual possession.",
                Anathema = "Disrespecting corpses or spirits is anathema to your instinct; defending yourself against undead creatures is not.",
                SpecializationAbility = "When using spirit rage, increase the damage from Rage from 3 to 7. If you have greater weapon specialization, instead increase the damage when using spirit rage to 13.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse("537018db-30e7-4d7b-af2f-db16e1c2c9b6"), InstinctAbilities.Instances.SpiritRage.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("ecd29935-dee9-4770-8768-e116ae063cd2"), DamageTypes.Instances.Negative.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.GainSpecificDamageResistance(Guid.Parse("23d12a85-7a46-494d-9fa9-22f5cf8e6fae"), DamageTypes.Instances.UndeadSource.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c165074-b3b5-4ff3-9fa7-8260a3c5f051"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 87
            };
        }
    }
}
