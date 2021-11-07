using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class DragonInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Dragon Instinct",
                Description = "You summon the fury of a mighty dragon and manifest incredible abilities. Perhaps your culture reveres draconic majesty, or you gained your connection by drinking or bathing in dragon's blood or after watching a marauding wyrm burn your village. Select a type of dragon from Table 3–4: Dragon Instincts to be your instinct's dragon type. Chromatic dragons tend to be evil, and metallic dragons tend to be good.",
                Anathema = "Letting a personal insult against you slide is anathema to your instinct. Choose whether your character respects or abhors your dragon type. If you respect it, defying such a dragon is anathema, and if you abhor it, failing to defeat such a dragon you come across is anathema.",
                SpecializationAbility = "When you use draconic rage, you increase the additional damage from Rage from 4 to 8. If you have greater weapon specialization, instead increase the damage from Rage when using draconic rage from 8 to 16.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse(""), InstinctAbilities.Instances.DraconicRage.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Piercing.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);

            builder.AddOr(Guid.Parse(""), or => 
            {
                or.Addendum("The chosen resistance effect should correlate with your Dragon's Breath weapon damage type.");
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse(""), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            });
        }

        protected override Table? GetTable()
        {
            return new TableBuilder()
                .AddColumn("", "Dragon Type")
                .AddColumn("", "Category")
                .AddColumn("", "Breadth Weapon")
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Black")
                        .AddCell("", "Chromatic")
                        .AddCell("", "Line of Acid");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Blue")
                        .AddCell("", "Chromatic")
                        .AddCell("", "Line of Electricit");
                })

                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Green")
                        .AddCell("", "Chromatic")
                        .AddCell("", "Cone of Poison");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Red")
                        .AddCell("", "Chromatic")
                        .AddCell("", "Cone of Fire");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "White")
                        .AddCell("", "Chromatic")
                        .AddCell("", "Cone of Cold");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Brass")
                        .AddCell("", "Metallic")
                        .AddCell("", "Line of Fire");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Bronze")
                        .AddCell("", "Metallic")
                        .AddCell("", "Line of Electricity");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Copper")
                        .AddCell("", "Metallic")
                        .AddCell("", "Line of Acid");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Gold")
                        .AddCell("", "Metallic")
                        .AddCell("", "Cone of Fire");
                })
                .AddRow("", row =>
                {
                    row
                        .AddCell("", "Silver")
                        .AddCell("", "Metallic")
                        .AddCell("", "Cone of Cold");
                })
                .Build("");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
