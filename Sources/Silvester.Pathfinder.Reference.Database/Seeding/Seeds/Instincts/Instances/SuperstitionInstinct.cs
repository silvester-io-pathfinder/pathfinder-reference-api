using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class SuperstitionInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                ClassId = Classes.Instances.Barbarian.ID,
                Name = "Superstition Instinct",
                Description = "A deep distrust of magic drives you to forgo and counter the metaphysical nonsense of spellcasters. Whether you're a member of a superstitious family or culture that distrusts magic, a warrior in constant battle against wizards and witches, a survivor of a magical accident that instilled an intense aversion in your mind and body, or a scion of a bloodline known for its magic resistance, your rage is inimical to magic. This makes you an excellent mage hunter but slow to trust practitioners of magical arts. Your extremely restrictive anathema grants you powers beyond those of other instincts.",
                Anathema = "Willingly accepting the effects of magic spells (including from scrolls, wands, and the like), even from your allies, is anathema to your instinct. You can still drink potions and invest and activate most magic items you find, though items that cast spells are subject to the same restrictions as all other spells. If an ally insists on using magic on you despite your unwillingness, and you have no reason to believe they will stop, continuing to travel with that ally of your own free will counts as willingly accepting their spells (as do similar circumstances) and thus is also anathema to your instinct.",
                SpecializationAbility = "Increase the damage from Rage from 4 to 8 against creatures that can cast spells. If you have greater raging specialization, instead increase the damage from Rage to 12 against creatures with spells and 8 against other creatures.",
            };
        }

        protected override Effect GetInstinctAbilityEffect()
        {
            return new GainSpecificInstinctAbilityEffect { Id = Guid.Parse(""), InstinctAbilityId = InstinctAbilities.Instances.SuperstitiousResilience.ID };
        }

        protected override IEnumerable<Effect> GetRagingEffects()
        {
            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Choices = new Effect[]
                {
                    new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.ArcaneTradition.ID },
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.OccultTradition.ID },
                        }
                    },
                    new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.ArcaneTradition.ID },
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.PrimalTradition.ID },
                        }
                    },
                    new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.DivineTradition.ID },
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.OccultTradition.ID },
                        }
                    },
                    new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.DivineTradition.ID },
                            new GainSpecificDamageResistanceEffect { Id = Guid.Parse(""), DamageTypeId = DamageTypes.Instances.PrimalTradition.ID },
                        }
                    }
                }
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 108
            };
        }
    }
}
