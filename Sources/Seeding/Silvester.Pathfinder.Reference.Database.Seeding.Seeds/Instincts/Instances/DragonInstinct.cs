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
        public static readonly Guid ID = Guid.Parse("8b01859e-ef0b-4e1e-8c1b-34f7f5350b4d");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Dragon Instinct",
                Description = "You summon the fury of a mighty dragon and manifest incredible abilities. Perhaps your culture reveres draconic majesty, or you gained your connection by drinking or bathing in dragon's blood or after watching a marauding wyrm burn your village. Select a type of dragon from Table 3�4: Dragon Instincts to be your instinct's dragon type. Chromatic dragons tend to be evil, and metallic dragons tend to be good.",
                Anathema = "Letting a personal insult against you slide is anathema to your instinct. Choose whether your character respects or abhors your dragon type. If you respect it, defying such a dragon is anathema, and if you abhor it, failing to defeat such a dragon you come across is anathema.",
                SpecializationAbility = "When you use draconic rage, you increase the additional damage from Rage from 4 to 8. If you have greater weapon specialization, instead increase the damage from Rage when using draconic rage from 8 to 16.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse("edf1bb91-5dbd-4883-a90e-2873fc363721"), InstinctAbilities.Instances.DraconicRage.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("9483451b-73c3-4b50-8476-21326613d30a"), DamageTypes.Instances.Piercing.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);

            builder.AddOr(Guid.Parse("a256e988-8005-47a2-ac68-d646d41a9fb9"), or => 
            {
                or.Addendum("The chosen resistance effect should correlate with your Dragon's Breath weapon damage type.");
                or.GainSpecificDamageResistance(Guid.Parse("eeda6b66-651b-4da9-847b-f53b75e3d285"), DamageTypes.Instances.Acid.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("e97722e7-eb64-4186-ab87-de28e0f4861b"), DamageTypes.Instances.Electricity.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("dd9f19ec-da51-42ef-a880-c1282fbc7a55"), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("523295cf-d1ce-4c7d-8fba-5dbe7505276d"), DamageTypes.Instances.Fire.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("91e9c82f-6a22-4022-a316-26fbbce5c920"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
                or.GainSpecificDamageResistance(Guid.Parse("8f1cc80b-9c5a-41e5-9263-d4d39227a909"), DamageTypes.Instances.Poison.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            });
        }

        protected override Table? GetTable()
        {
            return new TableBuilder()
                .AddColumn("72f3580f-4053-49b7-bf61-488518db03e7", "Dragon Type")
                .AddColumn("7eced65e-8ed6-4ebb-81ef-237280d0bb07", "Category")
                .AddColumn("f4240546-dda4-4b46-809f-5e005dfb0d73", "Breadth Weapon")
                .AddRow("2c6d19af-1acf-4b30-a328-3da75509b5f8", row =>
                {
                    row
                        .AddCell("4ac9ff64-d7d5-4625-bf0d-ba8384a1f369", "Black")
                        .AddCell("5bacf9af-524f-4863-89fb-aacacbc6cbd2", "Chromatic")
                        .AddCell("7466eed9-25f4-4a27-9ae0-0258c6e6d8bc", "Line of Acid");
                })
                .AddRow("40eb5872-7db7-4979-b809-8d83ec3d2b19", row =>
                {
                    row
                        .AddCell("521801df-2ed0-45dc-83dd-233209eda5e8", "Blue")
                        .AddCell("df93263f-8296-4070-bd61-4f3a27e69a5f", "Chromatic")
                        .AddCell("9069a050-c167-4073-b6e3-6d000945c281", "Line of Electricit");
                })

                .AddRow("06e3343b-a276-41b4-9ab1-d25075de4e49", row =>
                {
                    row
                        .AddCell("2f09ac3c-d722-4ced-8fc2-07ce3ecc84be", "Green")
                        .AddCell("2d63774f-937b-4f27-a5b8-c20c46e9477a", "Chromatic")
                        .AddCell("89795883-38fa-4626-91ed-7dcdafb3521e", "Cone of Poison");
                })
                .AddRow("d6be7b0c-3ac1-4de3-a74c-81c217e33733", row =>
                {
                    row
                        .AddCell("0b606824-00ba-4d16-861f-0085da6dfad4", "Red")
                        .AddCell("537d2b81-3a37-43da-a4c9-699d296f513c", "Chromatic")
                        .AddCell("39e83609-85a6-448e-8b91-e48edf8cf677", "Cone of Fire");
                })
                .AddRow("d9305b64-d09b-4a2c-aa1f-255ac165c98f", row =>
                {
                    row
                        .AddCell("4697a8a4-d2dc-46f8-badb-a8779695694f", "White")
                        .AddCell("fe88b267-9fa5-4bf9-b972-54239484b01f", "Chromatic")
                        .AddCell("97aaba9d-212e-4976-89e7-c2b331824713", "Cone of Cold");
                })
                .AddRow("a3d9e3f1-f44a-47c1-b9a4-7c9e3f6a14af", row =>
                {
                    row
                        .AddCell("caafd750-1b93-41b0-862b-a34f1eb2e61d", "Brass")
                        .AddCell("ecba0102-1a67-4075-8fc2-7dea4ef1dfa8", "Metallic")
                        .AddCell("57a6941b-84e9-424f-8cb1-936adc71ac1b", "Line of Fire");
                })
                .AddRow("21dca470-bb3a-4b54-a905-1ca6e855f6b8", row =>
                {
                    row
                        .AddCell("13b84b58-bd64-4142-883f-99982d471c53", "Bronze")
                        .AddCell("cf0596ff-f655-4f7f-9c68-8c339e0be273", "Metallic")
                        .AddCell("5b1b1cd3-4e5f-49ce-9736-cbdcc731d72e", "Line of Electricity");
                })
                .AddRow("b632e659-7cc1-414a-a2bc-09923c45d9a4", row =>
                {
                    row
                        .AddCell("afa0e5e3-b968-4db4-a188-731f3cf7348b", "Copper")
                        .AddCell("6fbc4fd3-cb18-4be8-9000-d2d736d6e29c", "Metallic")
                        .AddCell("98ca15b5-8a60-4c4e-a2ad-fec5fe2ce299", "Line of Acid");
                })
                .AddRow("4bbbab11-dc4c-4f39-b609-586be923b99b", row =>
                {
                    row
                        .AddCell("e62e0336-3fba-4eda-9bf8-69801ab62950", "Gold")
                        .AddCell("2576d46d-801f-440a-84e6-8a108faf3e0e", "Metallic")
                        .AddCell("e4b82b28-5e2e-4da2-83c4-2a17bfad49de", "Cone of Fire");
                })
                .AddRow("bddb221a-5911-44bc-a9d1-f018857dc951", row =>
                {
                    row
                        .AddCell("80e20a88-95a0-4eed-91bb-509fa6ff1802", "Silver")
                        .AddCell("20fc1857-088a-4276-a856-bf4fee27db20", "Metallic")
                        .AddCell("114dfce8-05d6-4ea5-9eb2-a81e9670b0f6", "Cone of Cold");
                })
                .Build("bea51fc6-b94b-4db2-bcce-75fe501bd7b1");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6ff1f095-8fa6-404a-9d38-5f34bfee3302"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
