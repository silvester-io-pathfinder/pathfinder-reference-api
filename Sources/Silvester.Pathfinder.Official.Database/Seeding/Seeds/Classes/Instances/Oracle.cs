using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Oracle : Template
    {
        public static readonly Guid ID = Guid.Parse("bc25beea-18e8-4417-8ada-a0f58bc79585");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Oracle",
                BaseHealth = 8,

                Description = "Your conduit to divine power eschews the traditional channels of prayer and servitude—you instead glean divine truths that extend beyond any single deity. You understand the great mysteries of the universe embodied in overarching concepts that transcend good and evil or chaos and law, whether because you perceive the common ground across multiple deities or circumvent their power entirely. You explore one of these mysteries and draw upon its power to cast miraculous spells, but that power comes with a terrible price: a curse that grows stronger the more you draw upon it. Your abilities are a double-edged sword, which you might uphold as an instrument of the divine or view as a curse from the gods.",
                DuringCombatEncounters = "You draw upon your mystery to empower yourself in combat, balancing miraculous effects with the increasing severity of your curse as conflicting divine demands overtax your physical body. You cast spells to aid your allies and devastate your foes, or depending on your mystery, you might wade into battle yourself.",
                DuringSocialEncounters = "You rely upon the insights drawn from your mystery. You might leverage your curse to intimidate people or hide its effects to better blend in.",
                WhileExploring = "You recenter yourself to bring the terrible metaphysical conflicts causing your curse back under control so you can draw upon your mystery’s power again later. You remain aware of supernatural forces acting around you, perhaps peeking into the future to gain insights.",
                InDowntime = "You might seek to learn more about your mystery and the divine wellsprings that fuel your power. Associating with others interested in the subject of your mystery can make it easier to live with your curse. You could associate with an organized religion or even start your own faithful following devoted to your mystery.",

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
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,

                SpellAttackProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PredefinedMagicTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("ccdda615-ea42-4aa1-9b39-4e69974a94a2"), Text = "View your oracular powers as a blessing, a curse, or both." };
            yield return new ClassMannerism { Id = Guid.Parse("27b78d7c-dfea-4d9c-ab76-cf18b899afce"), Text = "Push yourself to the limits of what you can withstand to work great acts of magic." };
            yield return new ClassMannerism { Id = Guid.Parse("03338b7c-68a3-4299-bcef-95f1a1439fb2"), Text = "Rely on magical items to provide a pool of safer and more reliable magic." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("fb491a4e-9c96-4e57-8c71-38c0069feb5a"), Text = "Don’t realize your spellcasting draws upon divine power and instead believe you command stranger—and possibly evil—powers." };
            yield return new ClassCharacteristic { Id = Guid.Parse("2e58f436-410b-44a4-b763-ff3b5a0b87df"), Text = "Assume you performed some terrible transgression to become cursed by the gods." };
            yield return new ClassCharacteristic { Id = Guid.Parse("7a73ed7d-74c3-432b-89f1-a73282c8bead"), Text = "Admire your determination and the sacrifices you make to perform wondrous acts." };
        }
    }
}
