using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Barbarian : Template
    {
        public static readonly Guid ID = Guid.Parse("a171edb5-59c0-4468-b710-a6b9df2f4497");

        protected override Class GetClass()
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

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Expert.ID,
                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
                ReflexProficiencyId = Proficiencies.Instances.Trained.ID,
                WillProficiencyId = Proficiencies.Instances.Expert.ID,
                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Strength.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("c7197881-4e0a-4816-b64e-bf0bb2eaf5f5"), Text = "Have a deep-seated well of anger, hatred, or frustration." };
            yield return new ClassMannerism { Id = Guid.Parse("9d16d728-b78b-47e8-adca-e6a8d75f2580"), Text = "Prefer a straightforward approach to one requiring patience and tedium." };
            yield return new ClassMannerism { Id = Guid.Parse("3de123ba-e38d-417b-a229-f84b6effa669"), Text = "Engage in a regimen of intense physical fitness—and punch anyone who says this conflicts with your distaste for patience and tedium." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("47d4e38b-f03a-4127-a673-243af7a327dc"), Text = "Rely on your courage and your strength, and trust that you can hold your own in a fight." };
            yield return new ClassCharacteristic { Id = Guid.Parse("42556a95-e0e0-40b5-8a5d-e031fd221d8d"), Text = "See you as uncivilized or a boorish lout unfit for high society." };
            yield return new ClassCharacteristic { Id = Guid.Parse("91bb3e45-7f52-441d-babc-b05303471515"), Text = "Believe that you are loyal to your friends and allies and will never relent until the fight is done." };
        }
    }
}
