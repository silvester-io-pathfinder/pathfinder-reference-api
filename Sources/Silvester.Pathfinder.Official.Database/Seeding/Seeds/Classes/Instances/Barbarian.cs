using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Barbarian : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("a171edb5-59c0-4468-b710-a6b9df2f4497");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Barbarian",
                BaseHealth = 12,

                Description = "Rage consumes you in battle. You delight in wreaking havoc and using powerful weapons to carve through your enemies, relying on astonishing durability without needing complicated techniques or rigid training. Your rages draw upon a vicious instinct, which you might associate with an animal, a spirit, or some part of yourself. To many barbarians, brute force is a hammer and every problem looks like a nail, whereas others try to hold back the storm of emotions inside them and release their rage only when it matters most.",
                DuringCombatEncounters = "You summon your rage and rush to the front lines to smash your way through. Offense is your best defense—you’ll need to drop foes before they can exploit your relatively low defenses.",
                DuringSocialEncounters = "You use intimidation to get what you need, especially when gentler persuasion can’t get the job done.",
                WhileExploring = "You look out for danger, ready to rush headfirst into battle in an instant. You climb the challenging rock wall and drop a rope for others to follow, and you wade into the risky currents to reach the hidden switch beneath the water’s surface. If something needs breaking, you’re up to the task!",
                InDowntime = "You might head to a tavern to carouse, build up the fearsome legend of your mighty deeds, or recruit followers to become a warlord in your own right.",

                ClassDcProficiencyId = seeder.GetProficiency("Trained"),
                PerceptionProficiencyId = seeder.GetProficiency("Expert"),
                FortitudeProficiencyId = seeder.GetProficiency("Expert"),
                ReflexProficiencyId = seeder.GetProficiency("Trained"),
                WillProficiencyId = seeder.GetProficiency("Expert"),
                SimpleWeaponProficiencyId = seeder.GetProficiency("Trained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Trained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),
                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Trained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Trained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained")
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Strength");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Have a deep-seated well of anger, hatred, or frustration." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Prefer a straightforward approach to one requiring patience and tedium." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Engage in a regimen of intense physical fitness—and punch anyone who says this conflicts with your distaste for patience and tedium." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Rely on your courage and your strength, and trust that you can hold your own in a fight." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "See you as uncivilized or a boorish lout unfit for high society." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Believe that you are loyal to your friends and allies and will never relent until the fight is done." };
        }
    }
}
