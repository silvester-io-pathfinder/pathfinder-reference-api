using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class GiantInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                ClassId = Classes.Instances.Barbarian.ID,
                Name = "Giant Instinct",
                Description = "Your rage gives you the raw power and size of a giant. This doesn't necessarily mean you revere giants—you might scoff at them or even aspire to slay them! You could instead seem like a giant to other people due to your exceptional strength or larger-than-life emotions and ego.",
                Anathema = "Failing to face a personal challenge of strength is anathema.",
                SpecializationAbility = "Increase the damage from Rage when using a larger weapon from 6 to 10; if you have greater weapon specialization, increase it from 10 to 18.",
            };
        }

        protected override Effect GetInstinctAbilityEffect()
        {
            return new GainSpecificInstinctAbilityEffect { Id = Guid.Parse(""), InstinctAbilityId = InstinctAbilities.Instances.TitanMauler.ID };
        }
        
        protected override IEnumerable<Effect> GetRagingEffects()
        {
            yield return new GainSpecificDamageResistanceEffect 
            { 
                Id = Guid.Parse(""),
                DamageTypeId = DamageTypes.Instances.Bludgeoning.ID 
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Choices = new Effect[]
                {
                    new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.Cold.ID },
                    new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.Electricity.ID },
                    new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.Fire.ID },
                }
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
