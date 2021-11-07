using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class FuryInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                ClassId = Classes.Instances.Barbarian.ID,
                Name = "Fury Instinct",
                Description = "Your rage comes from a deep and purely personal well within you. You use your rage as you choose.",
                Anathema = "You don't have an anathema or an instinct ability.",
                SpecializationAbility = "Increase the additional damage from Rage from 2 to 6. If you have greater weapon specialization, instead increase the additional damage from Rage to 12.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse(""), Classes.Instances.Barbarian.ID, level: 1);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.PhysicalWeapon.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
        }
      
        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 87
            };
        }
    }
}
