using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
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

        protected override Effect GetInstinctAbilityEffect()
        {
            return new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Barbarian.ID, Level = 1 };
        }

        protected override IEnumerable<Effect> GetRagingEffects()
        {
            yield return new GainSpecificDamageResistanceEffect
            {
                Id = Guid.Parse(""),
                DamageTypeId = DamageTypes.Instances.PhysicalWeapon.ID
            };
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
