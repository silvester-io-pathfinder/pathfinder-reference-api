using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Alchemist : Template
    {
        public static readonly Guid ID = Guid.Parse("df6b0137-7082-470f-939f-5d241ef7d651");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Alchemist",
                BaseHealth = 8,

                Description = "There’s no sight more beautiful to you than a strange brew bubbling in a beaker, and you consume your ingenious elixirs with abandon. You’re fascinated by uncovering the secrets of science and the natural world, and you’re constantly experimenting in your lab or on the go with inventive concoctions for every eventuality. You are fearless in the face of risk, hurling explosive or toxic creations at your foes. Your unique path toward greatness is lined with alchemical brews that push your mind and body to their limits.",
                DuringCombatEncounters = "You lob bombs at your foes, harry your enemies, and support the rest of your party with potent elixirs. At higher levels, your mutagens warp your body into a resilient and powerful weapon.",
                DuringSocialEncounters = "You provide knowledge and experience about alchemical items and related secrets, such as poisons and diseases.",
                WhileExploring = "You keep an eye out for trouble with your bombs at the ready, while giving advice on all things alchemical and mysterious.",
                InDowntime = "You experiment in an alchemical lab, brewing elixirs, making bombs, and furthering your alchemical knowledge.",

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Trained.ID,
                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
                ReflexProficiencyId = Proficiencies.Instances.Expert.ID,
                WillProficiencyId = Proficiencies.Instances.Trained.ID,
                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("f20c0e04-8d8a-42e0-b96f-1065ad387b86"), Text = "Enjoy tinkering with strange formulas and alchemical reagents, often with a single - minded dedication and recklessness that gives others pause." };
            yield return new ClassMannerism { Id = Guid.Parse("3553ea25-69b9-436e-a064-ed8fc9ea9b15"), Text = "Get a kick out of wreaking havoc with the alchemical concoctions you’ve made, and enjoy watching things burn, dissolve, freeze, and jolt." };
            yield return new ClassMannerism { Id = Guid.Parse("6560d9a9-d4ed-4db1-aa66-9d58aba19a0b"), Text = "Endlessly experiment to discover new, more potent alchemical tools." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("1d2ddb19-c3f5-46c9-81ce-5307e7f66fb4"), Text = "Think you’re some kind of sorcerer or an eccentric wizard and don’t understand that you don’t cast spells; spellcasters who clumsily dabble in alchemy only heighten this misconception." };
            yield return new ClassCharacteristic { Id = Guid.Parse("2ac61aa9-12df-4c66-a4ab-191cb396d316"), Text = "Don’t understand your zeal for alchemy, creativity, and invention." };
            yield return new ClassCharacteristic { Id = Guid.Parse("b08d6ce0-c333-4a87-9e45-3c3815ad24b7"), Text = "Assume that if you haven’t caused a catastrophe with your experimentations, you inevitably will." };
        }

        /*protected override IEnumerable<ClassFeature> GetFeatures(ClassSeeder seeder)
        {
            yield return new ClassFeature { Id = Guid.Parse("9f7d861b-755b-4a61-b174-a7ba4f905eee"), Level = 1, Name = "Ancestry and Background", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("b392ab1a-07dd-4896-895f-ea04cd3b9c20"), Level = 1, Name = "Initial Proficiencies", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("0f0742fc-512e-4ede-9877-95327d5584f4"), Level = 1, Name = "Alchemy", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("7f6c2af7-232e-4104-b28d-7cebaf3c7b70"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("6bda7326-3061-4288-8fee-edb77baee8c0"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("8453a4b0-a70f-4fff-a623-c56a7f50fec4"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("5af547e3-3092-4e56-8acf-1811930bde06"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("6a9731e9-dfd2-45fc-b1b8-d1994d8a7f28"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("8670b7a0-d187-4a1b-80aa-1158de4fabae"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("54fe1739-45df-4623-a6fe-a1898b9c0f96"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("010dfd99-3005-49a0-a0d2-2cf7c6b0a958"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("cb6796c0-4981-4662-a81c-b9ce03be5a2f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("7b2de405-4c8e-48c5-aabd-446c9d2f26ef"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("82ea2ebc-fb02-429e-bb96-3363dd8d13cf"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("c179942c-a49a-4093-af8d-43aa837862ce"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("b5956902-75fc-4112-ba0c-6203352be6c0"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("7a3f82f7-b232-4f8e-b17e-f7082e7a0150"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("50456aa5-4de2-40dd-8f9c-73bb7a574079"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("c4c427a4-7299-4bd3-937e-9b26c6af75e1"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("048855ea-d74f-468f-b74f-6edf9d2072b9"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("b7493a64-df56-4f89-9fc5-3aef3b69985e"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("a9624c43-5ebe-4775-8698-604f0173c807"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("cbb1a3e2-b99e-4a62-b726-646259eddaaa"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("1b95efcc-2ad8-46d3-9e21-ffe2112c9139"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("3b3fc71f-9e8a-4237-b570-a66ddff5c818"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("03c76370-1467-4137-b8a2-a3c148e823ff"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("f5db1c1b-4c07-43ad-b3b6-252009d9070d"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("ee7f419d-ed19-4975-8929-16a290f87975"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("0c06c07f-7867-4796-98ba-d4dc356c0379"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("793f4a99-8999-434e-ac23-9009253b60c8"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("111361f2-447a-404b-8c9b-05eb32bd3c95"), Level = 1, Name = "", Description = "" };
        }*/
    }
}
