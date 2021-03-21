﻿using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Rogue : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("4087e406-d324-45af-b9b9-9adf0283a17c");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Rogue",
                BaseHealth = 8,

                Description = "You are skilled and opportunistic . Using your sharp wits and quick reactions, you take advantage of your opponents’ missteps and strike where it hurts most. You play a dangerous game, seeking thrills and testing your skills, and likely don’t care much for any laws that happen to get in your way. While the path of every rogue is unique and riddled with danger, the one thing you all share in common is the breadth and depth of your skills.",
                DuringCombatEncounters = "You move about stealthily so you can catch foes unawares. You’re a precision instrument, more useful against a tough boss or distant spellcaster than againstrank - and - file soldiers.",
                DuringSocialEncounters = "Your skills give you multiple tools to influence your opposition. Pulling cons and ferreting out information are second nature to you.",
                WhileExploring = "You sneak to get the drop on foes and scout for danger or traps. You’re a great asset, since you can disable traps, solve puzzles, and anticipate dangers.",
                InDowntime = "You might pick pockets or trade in illegal goods. You can also become part of a thieves’ guild, or even found one of your own.",

                ClassDcProficiencyId = seeder.GetProficiency("Trained"),
                PerceptionProficiencyId = seeder.GetProficiency("Expert"),

                FortitudeProficiencyId = seeder.GetProficiency("Trained"),
                ReflexProficiencyId = seeder.GetProficiency("Expert"),
                WillProficiencyId = seeder.GetProficiency("Expert"),

                SimpleWeaponProficiencyId = seeder.GetProficiency("Trained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),

                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Trained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Untrained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained"),
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Strength", "Intellect", "Charisma");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse("2050d6a7-747d-4e76-8c0d-1ddc09b4ec53"), Text = "Hone your skills through intense practice, both on your own and out in the world." };
            yield return new ClassMannerism { Id = Guid.Parse("75025372-a5b4-49f9-89e6-b46f146ca281"), Text = "Know where to attain illicit goods." };
            yield return new ClassMannerism { Id = Guid.Parse("7a5115d6-8a23-4616-83bc-a2ff379db0c2"), Text = "Skirt or break the law because you think it’s meaningless or have your own code." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("4184690e-d9de-4daa-959f-cd13811949a1"), Text = "Find you charming or fascinating, even if they think they know better than to trust you." };
            yield return new ClassCharacteristic { Id = Guid.Parse("5a54de41-6cf6-4bb4-a971-06f01270cf9e"), Text = "Come to you when they need someone who is willing to take risks or use questionable methods." };
            yield return new ClassCharacteristic { Id = Guid.Parse("8f67f4eb-f9d6-4c17-915f-950eb88ccccd"), Text = "Suspect you’re motivated primarily by greed." };
        }
    }
}