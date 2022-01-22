using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Tables;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Instincts.Instances
{
    public class AnimalInstinct : Template
    {
        public static readonly Guid ID = Guid.Parse("27da3f44-64c1-4e4e-8c4c-1ee388353f9c");
        
        protected override Instinct GetInstinct()
        {
            return new Instinct
            {
                Id = ID, 
                Name = "Animal Instinct",
                Description = "The fury of a wild predator fills you when you Rage, granting you ferocious unarmed attacks. Cultures that revere vicious animals (such as apes or bears) give rise to barbarians with this instinct. You might also be at war with an uncontrollable, animalistic side of your personality, or you might be a descendant of a werewolf or another werecreature. Select an animal from the table Animal Instincts that best matches your chosen animal.",
                Anathema = "Flagrantly disrespecting an animal of your chosen kind is anathema to your instinct, as is using weapons while raging.",
                SpecializationAbility = "Increase the damage die size for the unarmed attacks granted by your chosen animal by one step, and increase the additional damage from Rage from 2 to 5 for your chosen animal's unarmed attacks. The frog's tongue attack and deer's antler attack gain reach 10 feet. If you have greater weapon specialization, increase the damage from Rage from 5 to 12 for your chosen animal's unarmed attacks.",
            };
        }

        protected override void GetInstinctAbilityEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInstinctAbility(Guid.Parse("5735fbc7-90b3-406d-9620-84405e04681f"), InstinctAbilities.Instances.BestialRage.ID);
        }

        protected override void GetRagingEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("fc65901e-f416-465a-a1da-11017ba3f067"), DamageTypes.Instances.Piercing.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
            builder.GainSpecificDamageResistance(Guid.Parse("371dda9b-9643-4c31-874f-2a45d92269f4"), DamageTypes.Instances.Slashing.ID, ModifierInput.Damage, ModifierType.Multiply, modifier: 0, minimum: 0);
        }

        protected override Table? GetTable()
        {
            return new TableBuilder("4e41a29d-f02c-455e-b3ff-61f4f0dbb0d1")
                .AddColumn("c45339a3-10d5-4384-81a8-9fee34aead87", "Animal")
                .AddColumn("f2f7b6be-8bb7-48c5-9423-976ed064ecf9", "Attack")
                .AddColumn("cb939f8e-1471-4308-8e72-441498ed0e7a", "Damage")
                .AddColumn("54861dcf-4876-4cad-bc75-c0dd378a43d9", "Traits")
                .AddRow("62df1bb8-59c0-4ea3-850b-052e3f1c4d16", row =>
                {
                    row
                        .AddCell("bc98c61e-e01a-477a-9366-fc3b801e4cf2", "Ape")
                        .AddCell("8a31af54-c646-4228-986a-83eae0c83f88", "Fist")
                        .AddCell("2b524831-9413-4186-8a92-a6789f8b8b06", "1d10 B")
                        .AddCell("05b6e088-a660-46e4-951a-325929f58adf", "Grapple, Unarmed");
                })
                .AddRow("7a9dd956-18c3-4dc5-b6c2-604ff0c7bd57", row =>
                {
                    row
                        .AddCell("ded3ab39-40eb-41af-91b2-8ea808d86ce4", "Bear")
                        .AddCell("de0cb3e4-3101-4903-9130-fdfde271e8bc", "Jaws")
                        .AddCell("8910e7f3-604f-49fd-a2dd-2e37e1ee3641", "1d10 P")
                        .AddCell("9ff3c84d-88be-4636-8551-be9137caa2a0", "Unarmed");
                })
                .AddRow("f400f401-6559-4856-9b93-fcfab536d052", row =>
                {
                    row
                        .AddCell("328b45ab-90f2-4c53-a328-7fcd96258ac9", "Bear")
                        .AddCell("69640d6a-1f6d-4919-a1dd-ccee1877affb", "Claw")
                        .AddCell("6ae4ecf6-ecd7-4605-8085-e4f7c83d1bf7", "1d6 S")
                        .AddCell("f61c5283-bfc4-4f0a-9c18-e80c2b09cd0a", "Agile, Unarmed");
                })
                .AddRow("e803972c-add3-4200-9acc-d5401c07293e", row =>
                {
                    row
                        .AddCell("c15a9fbd-1942-412d-a57d-b217f9daf8e3", "Bull")
                        .AddCell("cc46fbff-137d-4818-823e-ca7b67b54da3", "Horn")
                        .AddCell("02fc5e73-8756-4cac-8fb5-00f9e0a58610", "1d10 P")
                        .AddCell("16e55544-3026-46db-a481-f87e452e9713", "Shove, Unarmed");
                })
                .AddRow("b1fa0f9d-e668-43f7-af82-c0a19fa4efd6", row =>
                {
                    row
                        .AddCell("19f28162-721d-488a-903e-2750bcb495f7", "Cat")
                        .AddCell("59311f23-3d71-4a63-ab0e-fb42566bcf60", "Jaws")
                        .AddCell("fee6a6e0-6eef-48e6-9904-e3ebcee06d09", "1d10 P")
                        .AddCell("da203e8f-26b2-482a-ab20-d5931fc44948", "Unarmed");
                })
                .AddRow("b32e732c-a660-4016-ad32-602372a7d619", row =>
                {
                    row
                        .AddCell("17cad561-7dc5-48f0-a2b1-e3130881a26c", "Cat")
                        .AddCell("28fdf02c-adea-493e-b90c-961f2165b972", "Claw")
                        .AddCell("cac9d722-fb2b-4f7f-a08e-03b0fcd05987", "1d6 S")
                        .AddCell("827747f6-379b-4ec7-858f-c6c9cad47a06", "Agile, Unarmed");
                })
                .AddRow("b99f9cd4-057b-4d47-8ddf-b554f6a48433", row =>
                {
                    row
                        .AddCell("1f26288f-058f-42e4-a15b-0129aa3ba44e", "Deer")
                        .AddCell("2e3f6183-2c0b-4e11-9a69-dd0746df514b", "Antler")
                        .AddCell("5d272c9e-93da-45eb-a200-af638d39235c", "1d10 P")
                        .AddCell("75667699-3645-4f3c-8060-cd37102b7199", "Grapple, Unarmed");
                })
                .AddRow("340ad747-6312-40ec-bd06-6a52246d7f2c", row =>
                {
                    row
                        .AddCell("a3047f3c-8208-4459-9741-c6c61cbcce82", "Frog")
                        .AddCell("b3a2ef76-8acb-411b-b8e1-6269fc39b51b", "Jaws")
                        .AddCell("bb1b29dd-e329-40ac-ba83-8a4247c14234", "1d10 B")
                        .AddCell("970182bc-5d7b-4806-8e27-d24f3585cd9f", "Unarmed");
                })
                .AddRow("56e76243-506c-48d5-b248-d47eccd491ac", row =>
                {
                    row
                        .AddCell("05dd92c4-51d4-4785-89f4-359575308232", "Frog")
                        .AddCell("ef17d73a-d761-4a8c-b1b3-6bf048228bfd", "Tongue")
                        .AddCell("3fcab6a3-cd5a-45b1-b343-394c163ceb12", "1d10 B")
                        .AddCell("316617bb-6f75-4cec-af9d-bad3d0a21f01", "Agile, Unarmed");
                })
                .AddRow("37a08035-43ca-4464-b42e-6eccbad1f2d9", row =>
                {
                    row
                        .AddCell("30864b58-0542-48b3-8138-2332c1bf0986", "Shark")
                        .AddCell("06b87ae4-a1b1-4c46-aa23-7b9ecbbecc6b", "Jaws")
                        .AddCell("2ae84786-ac25-4c34-8a0f-f025d8dbb8b4", "1d10 P")
                        .AddCell("f45f2d99-26ca-4731-aad8-d0e8c287a7c0", "Grapple, Unarmed");
                })
                .AddRow("aece0acf-5050-447f-a743-7119b717ce61", row =>
                {
                    row
                        .AddCell("f9e50f46-9ad2-41ac-a142-3c9a6c1e04b6", "Snake")
                        .AddCell("ae5f65c6-e11f-442c-a622-443889f5912d", "Jaws")
                        .AddCell("5ec9c3a1-604d-422d-b46f-38d1a2118be7", "1d10 P")
                        .AddCell("16e0f32e-c6fa-4560-8186-ef51250ae249", "Grapple, Unarmed");
                })
                .AddRow("417e7403-24c4-41d3-81f2-27ecc9506833", row =>
                {
                    row
                        .AddCell("98a4984a-f755-4086-9697-1a17ccd90e22", "Wolf")
                        .AddCell("a315a132-e4eb-4307-b7af-4ac712885826", "Jaws")
                        .AddCell("d95080a1-17ba-430e-9f97-5e60ac230461", "1d10 P")
                        .AddCell("eb016133-bd37-4b6f-9696-f71218a2d1ca", "Trip, Unarmed");
                })
                .Build();
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81f0d771-1a3a-4085-b9fd-00fa1658030d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 86
            };
        }
    }
}
