using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
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
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "Ancestry and Background", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "Initial Proficiencies", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "Alchemy", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
            yield return new ClassFeature { Id = Guid.Parse("4b3f077a-0894-42d0-9e9d-0225d2be513f"), Level = 1, Name = "", Description = "" };
        }*/
    }
}
