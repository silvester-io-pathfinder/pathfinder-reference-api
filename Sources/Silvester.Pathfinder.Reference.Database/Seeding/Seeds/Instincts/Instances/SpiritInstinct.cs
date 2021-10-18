using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class SpiritInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                ClassId = Classes.Instances.Barbarian.ID,
                Name = "Spirit Instinct",
                Description = "Whether you are emotionally sensitive to the spirits around you; worship ancestors or apparitions; or are haunted by the specter of an ancestor, relative, friend, or foe, your rage takes the form of a spiritual possession.",
                Anathema = "Disrespecting corpses or spirits is anathema to your instinct; defending yourself against undead creatures is not.",
                SpecializationAbility = "When using spirit rage, increase the damage from Rage from 3 to 7. If you have greater weapon specialization, instead increase the damage when using spirit rage to 13.",
            };
        }

        protected override Effect GetInstinctAbilityEffect()
        {
            return new GainSpecificInstinctAbilityEffect { Id = Guid.Parse(""), InstinctAbilityId = InstinctAbilities.Instances.SpiritRage.ID };
        }

        protected override IEnumerable<Effect> GetRagingEffects()
        {
            yield return new GainSpecificDamageResistanceEffect
            {
                Id = Guid.Parse(""),
                DamageTypeId = DamageTypes.Instances.Negative.ID
            };

            yield return new GainSpecificDamageResistanceEffect
            {
                Id = Guid.Parse(""),
                DamageTypeId = DamageTypes.Instances.UndeadSource.ID
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
