using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Witch : Template
    {
        public static readonly Guid ID = Guid.Parse("de966e73-2c40-40b4-956f-57e326f7ce8e");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Witch",
                BaseHealth = 6,

                Description = "You command powerful magic, not through study or devotion to any ideal, but as a vessel or agent for a mysterious, otherworldly patron that even you don’t entirely understand. This entity might be a covert divinity, a powerful fey, a manifestation of natural energies, an ancient spirit, or any other mighty supernatural being—but its nature is likely as much a mystery to you as it is to anyone else. Through a special familiar, your patron grants you versatile spells and powerful hexes to use as you see fit, though you’re never certain if these gifts will end up serving your patron’s larger plan.",
                DuringCombatEncounters = "You cast spells to change the course of battle. You use magical hexes to hamper enemies and aid allies, while leveraging more powerful spells to control the battlefield, heal, or harm, aided by your extraordinary familiar, brewed potions, and magical items.",
                DuringSocialEncounters = "You provide knowledge on numerous topics, including a variety of magical matters, and you might call upon your patron’s magic to charm or deceive others.",
                WhileExploring = "You remain alert for magical traps and treasures, employing a clever array of spells to overcome obstacles that stand in your way. Your familiar might aid you through its own considerable set of exceptional abilities.",
                InDowntime = "You brew potions, craft other magical items, or hunt for new spells for your familiar to learn. You might try to learn more about your patron, their aims, or your own powers, and you might seek out the company of other witches for collaboration or community.",

                ClassDcProficiencyId = Proficiencies.Instances.Untrained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Trained.ID,

                FortitudeProficiencyId = Proficiencies.Instances.Trained.ID,
                ReflexProficiencyId = Proficiencies.Instances.Trained.ID,
                WillProficiencyId = Proficiencies.Instances.Expert.ID,

                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,

                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,

                SpellAttackProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PredefinedMagicTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("c0b4b5d3-a43d-4fa0-9382-f361f2c307c5"), Text = "Have an unquenchable intellectual curiosity about how everything in the world around you works—magic in particular." };
            yield return new ClassMannerism { Id = Guid.Parse("0496b73c-c75f-4ea3-a549-e76e18fca052"), Text = "Believe fervently that your school of magic is superior (if you’re a specialist) or that true mastery of magic requires knowledge of all schools (if you’re a universalist)." };
            yield return new ClassMannerism { Id = Guid.Parse("72df3174-ac1c-47b0-bb8c-ef962e743bc4"), Text = "Use esoteric jargon and technical terms to precisely describe the minutiae of magical effects, even though the difference is probably lost on other people." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("4fb1e29a-92c0-4d15-8963-fb39b9a39887"), Text = "Consider you to be incredibly powerful and potentially dangerous." };
            yield return new ClassCharacteristic { Id = Guid.Parse("09921c78-f5c8-4fe2-a8bb-7f5ae4d33ec3"), Text = "Fear what your magic can do to their minds, bodies, and souls, and ask that you avoid casting spells in polite company, as few can identify whether one of your spells is harmless or malevolent until it’s too late." };
            yield return new ClassCharacteristic { Id = Guid.Parse("8c20d58a-927d-4ea5-83c9-be47682cb32b"), Text = "Assume you can easily solve all their problems, from dangerous weather to poor crop yields, and ask you for spells that can help them get whatever they desire." };
        }
    }
}
