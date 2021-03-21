using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Ranger : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("ceb15fca-8288-456e-9769-98cce79bb104");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Ranger",
                BaseHealth = 10,

                Description = "Some rangers believe civilization wears down the soul, but still needs to be protected from wild creatures.Others say nature needs to be protected from the greedy, who wish to tame its beauty and plunder its treasures.You could champion either goal, or both. You might be a scout, tracker, or hunter of fugitives or beasts, haunting the edge of civilization or exploring the wilds.You know how to live off the land and are skilled at spotting and taking down both opportune prey and hated enemies.",
                DuringCombatEncounters = "You can single out particular foes to hunt, making you better at defeating them. You target and brutalize your chosen foe with either a bow or melee weapons, while supporting your allies with your skills.",
                DuringSocialEncounters = "When you speak, it’s with the voice of practical experience, especially involving wilderness exploration.",
                WhileExploring = "You guide your allies through the wilderness or follow tracks. You keep an eye out for trouble, constantly alert for danger even when it’s not overt.",
                InDowntime = "You craft weapons and train animals in preparation for your next venture. If you prefer to get outside, you might go on hunts or scout nearby areas to better understand your environment.",

                ClassDcProficiencyId = seeder.GetProficiency("Trained"),
                PerceptionProficiencyId = seeder.GetProficiency("Expert"),

                FortitudeProficiencyId = seeder.GetProficiency("Expert"),
                ReflexProficiencyId = seeder.GetProficiency("Expert"),
                WillProficiencyId = seeder.GetProficiency("Trained"),

                SimpleWeaponProficiencyId = seeder.GetProficiency("Trained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Trained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),

                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Trained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Trained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained"),
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Strength", "Dexterity");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse("a6ef7d5a-5f11-4395-bf46-28966b389f03"), Text = "Respect the raw power of nature and understand how to make the best of its bounty." };
            yield return new ClassMannerism { Id = Guid.Parse("e4bd8f4d-0774-435c-8b5f-6e4dcc3d18a4"), Text = "Enjoy the thrill of the hunt." };
            yield return new ClassMannerism { Id = Guid.Parse("91551570-edd4-4240-8bea-cc80473f9e5b"), Text = "Scout out ahead of the party, reconnoitering dangers before combat begins." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("97b80324-7529-4d87-86b2-bed2f01577d4"), Text = "Call upon you to protect them from the wilds or the encroachment of civilization." };
            yield return new ClassCharacteristic { Id = Guid.Parse("4979afa1-38b9-45c1-a9a8-c64fd66912a9"), Text = "Expect you to be a quiet or taciturn loner." };
            yield return new ClassCharacteristic { Id = Guid.Parse("56e1268b-2f13-47e6-95ca-5755e37ca9e7"), Text = "Think there is something dangerous and wild about you." };
        }
    }
}
