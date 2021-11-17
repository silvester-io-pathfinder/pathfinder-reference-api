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
        public static readonly Guid ID = Guid.Parse("7ec73775-d196-4b05-af69-171caeff52dd");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Fury Instinct",
                Description = "Your rage comes from a deep and purely personal well within you. You use your rage as you choose.",
                Anathema = "You don't have an anathema or an instinct ability.",
                SpecializationAbility = "Increase the additional damage from Rage from 2 to 6. If you have greater weapon specialization, instead increase the additional damage from Rage to 12.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("0f17b8a7-e7e6-4d1b-8c11-448f70556e19"), Classes.Instances.Barbarian.ID, level: 1);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("9d9f5f15-785d-4ac1-9e78-bb070edfa1fd"), DamageTypes.Instances.PhysicalWeapon.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
        }
      
        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5cde3e09-04bf-4cd5-9750-7a6499def60c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 87
            };
        }
    }
}
