using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Monk : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("a0dcd60b-b52e-4f96-a96c-50ac2ca73d91");

        protected override Class GetClass()
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

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Trained.ID,

                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
                ReflexProficiencyId = Proficiencies.Instances.Expert.ID,
                WillProficiencyId = Proficiencies.Instances.Expert.ID,

                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,

                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("cee3ea9b-e7cd-43ab-a2e0-1cfaa5abcc61"), Text = "Maintain a regimen of physical training and meditation." };
            yield return new ClassMannerism { Id = Guid.Parse("25352f03-9d39-46fe-af17-39417ec66512"), Text = "Face adversity with a calm and measured approach, never panicking or succumbing to despair." };
            yield return new ClassMannerism { Id = Guid.Parse("7e27c04c-ae5e-4a6e-b18a-fbdf61ed93e4"), Text = "Look to the future for ways you can improve, while remaining at peace with your present self." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("01a10cfa-4e2b-4668-bc1c-939754abd9b4"), Text = "Marvel at your feats of physical prowess." };
            yield return new ClassCharacteristic { Id = Guid.Parse("2d776caa-fcbf-420b-aed9-a56ee5c6a8aa"), Text = "Think you’re more than a bit uptight, given your vows and tenets." };
            yield return new ClassCharacteristic { Id = Guid.Parse("16536a58-583e-454b-a549-c2a2f6496c11"), Text = "Come to you for philosophical advice." };
        }
    }
}
