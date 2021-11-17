using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class SuperstitionInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("e86efc6e-05d6-418a-a251-6c0ec192e9ee");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Superstition Instinct",
                Description = "A deep distrust of magic drives you to forgo and counter the metaphysical nonsense of spellcasters. Whether you're a member of a superstitious family or culture that distrusts magic, a warrior in constant battle against wizards and witches, a survivor of a magical accident that instilled an intense aversion in your mind and body, or a scion of a bloodline known for its magic resistance, your rage is inimical to magic. This makes you an excellent mage hunter but slow to trust practitioners of magical arts. Your extremely restrictive anathema grants you powers beyond those of other instincts.",
                Anathema = "Willingly accepting the effects of magic spells (including from scrolls, wands, and the like), even from your allies, is anathema to your instinct. You can still drink potions and invest and activate most magic items you find, though items that cast spells are subject to the same restrictions as all other spells. If an ally insists on using magic on you despite your unwillingness, and you have no reason to believe they will stop, continuing to travel with that ally of your own free will counts as willingly accepting their spells (as do similar circumstances) and thus is also anathema to your instinct.",
                SpecializationAbility = "Increase the damage from Rage from 4 to 8 against creatures that can cast spells. If you have greater raging specialization, instead increase the damage from Rage to 12 against creatures with spells and 8 against other creatures.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse("c92e5be1-86a6-4e3b-bdcf-44e5e09a62cc"), InstinctAbilities.Instances.SuperstitiousResilience.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("5963ee2e-2f2c-4527-b805-d616c35e7303"), or =>
            {
                or.AddAnd(Guid.Parse("a27daee1-198f-4b79-96b7-99ca06a73257"), and =>
                {
                    and.GainSpecificDamageResistance(Guid.Parse("8af8f0c1-1cd9-405d-9809-c019a21b29a2"), DamageTypes.Instances.ArcaneTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                    and.GainSpecificDamageResistance(Guid.Parse("a2c776fb-49c1-45ab-8d8a-8f8660aefa74"), DamageTypes.Instances.OccultTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                });

                or.AddAnd(Guid.Parse("ce51c52d-5efd-4a04-b930-dc2af0ff64d4"), and =>
                {
                    and.GainSpecificDamageResistance(Guid.Parse("7761617c-b4a3-43d4-8022-ab6101b1e970"), DamageTypes.Instances.ArcaneTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                    and.GainSpecificDamageResistance(Guid.Parse("989b2052-d768-4da4-82f1-d6dcb88fb18f"), DamageTypes.Instances.PrimalTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                });

                or.AddAnd(Guid.Parse("958d937a-f55f-43e3-8a60-4710f7ca1ae3"), and =>
                {
                    and.GainSpecificDamageResistance(Guid.Parse("16765f39-820f-49bd-be72-c37ad183c97a"), DamageTypes.Instances.DivineTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                    and.GainSpecificDamageResistance(Guid.Parse("5e214c6f-77a6-4a85-a185-7094eb7feb39"), DamageTypes.Instances.OccultTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                });

                or.AddAnd(Guid.Parse("2fbe57d4-ba90-408e-825c-e6d2ece7ee46"), and =>
                {
                    and.GainSpecificDamageResistance(Guid.Parse("c1f604f2-6fc2-41eb-85de-49927c80deb4"), DamageTypes.Instances.DivineTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                    and.GainSpecificDamageResistance(Guid.Parse("88762acd-4bb1-4295-8cb4-2b59b09048cc"), DamageTypes.Instances.PrimalTradition.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee8a546e-6d5c-440e-af15-bfb86e033a95"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 108
            };
        }
    }
}
