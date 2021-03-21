using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Monk : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Monk",
                BaseHealth = 10,

                Description = "The strength of your fist flows from your mind and spirit. You seek perfection—honing your body into a flawless instrument and your mind into an orderly bastion of wisdom.You’re a fierce combatant renowned for martial arts skills and combat stances that grant you unique fighting moves.While the challenge of mastering many fighting styles drives you to great heights, you also enjoy meditating on philosophical questions and discovering new ways to obtain peace and enlightenment.",
                DuringCombatEncounters = "You speed into the fray, dodging or leaping past obstacles with acrobatic maneuvers. You strike opponents in a rapid flurry of attacks, using your bare fists or wielding specialized weapons that you mastered during your monastic training. Stances let you change up your combat style for different situations, and ki abilities allow you to perform mystic feats like healing yourself and soaring through the air.",
                DuringSocialEncounters = "Your perceptiveness lets you see through falsehoods, and your philosophical trainingprovides insight into any situation.",
                WhileExploring = "You climb up walls, dodge traps, overcome obstacles, and leap over pits. You usually stay toward the outside of the group to protect more vulnerable members, and you’re well suited to looking for danger or moving stealthily.",
                InDowntime = "You diligently exercise, eat healthy foods, meditate, and study various philosophies. You might also take up a craft that you strive to perfect.",

                ClassDcProficiencyId = seeder.GetProficiency("Trained"),
                PerceptionProficiencyId = seeder.GetProficiency("Trained"),

                FortitudeProficiencyId = seeder.GetProficiency("Expert"),
                ReflexProficiencyId = seeder.GetProficiency("Expert"),
                WillProficiencyId = seeder.GetProficiency("Expert"),

                SimpleWeaponProficiencyId = seeder.GetProficiency("Trained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),

                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Untrained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Untrained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained"),
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Strength", "Dexterity");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Maintain a regimen of physical training and meditation." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Face adversity with a calm and measured approach, never panicking or succumbing to despair." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Look to the future for ways you can improve, while remaining at peace with your present self." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Marvel at your feats of physical prowess." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Think you’re more than a bit uptight, given your vows and tenets." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Come to you for philosophical advice." };
        }
    }
}
