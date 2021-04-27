using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Druid : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("73f7051c-8eff-4337-a87c-183deb7a998c");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Druid",
                BaseHealth = 8,

                Description = "The power of nature is impossible to resist. It can bring ruin to the stoutest fortress in minutes, reducing even the mightiest works to rubble, burning them to ash, burying them beneath an avalanche of snow, or drowning them beneath the waves. It can provide endless bounty and breathtaking splendor to those who respect it— and an agonizing death to those who take it too lightly. You are one of those who hear nature’s call. You stand in awe of the majesty of its power and give yourself over to its service.",
                DuringCombatEncounters = "You call upon the forces of nature to defeat your enemies and protect your allies. You cast spells that draw upon primal magic to protect yourself and your friends, heal their wounds, or summon deadly animals to fight at your side. Depending on your bond to nature, you might call upon powerful elemental magic or change shape into a terrifying beast.",
                DuringSocialEncounters = "You represent balance and a reasoned approach to problems, looking for solutions that not only are best for the natural world, but also allow the creatures within it to live in harmony and peace.You often propose compromises that allow both sides to gain what they truly need, even if they can’t have all that they desire.",
                WhileExploring = "Your nature skills are invaluable. You track down enemies, navigate the wilderness, and use spells to detect magical auras around you.You might even ask wild animals to lend their extraordinary senses and scouting abilities to your group.",
                InDowntime = "You might craft magic items or potions. Alternatively, your tie to nature might lead you to tend a wilderness area, befriending beasts and healing the wounds caused by  civilization.You might even teach sustainable farming and animal husbandry techniquesthat allow others to subsist off the land without harming the natural balance.",

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
                MediumArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,

                SpellAttackProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PredefinedMagicTraditionId = MagicTraditions.Instances.Primal.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("fdb38cc9-5b9e-45c3-ae43-660d5aaa3675"), Text = "Have a deep and meaningful respect for the power of nature." };
            yield return new ClassMannerism { Id = Guid.Parse("22d2fbc4-04ce-4b41-b119-9459dd877a65"), Text = "Be in constant awe of the natural world, eager to share it with others but wary of their influence upon it." };
            yield return new ClassMannerism { Id = Guid.Parse("1d27448a-3fb0-47cb-b126-85f4a433fe9e"), Text = "Treat plants and animals as allies, working with them to reach your goals." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("2a801590-b596-4584-ac5a-1c65015ef184"), Text = "View you as a representative of nature, and are sure you can control it." };
            yield return new ClassCharacteristic { Id = Guid.Parse("62e621eb-b0ee-4622-914f-a70b8e84dbfc"), Text = "Assume you’re a recluse who avoids society and cities and prefers to live in the wild." };
            yield return new ClassCharacteristic { Id = Guid.Parse("82532d8e-b943-4aed-b14e-e3a302ade578"), Text = "Consider you a mystic, similar to a priest, but answering only to the forces of nature." };
        }
    }
}
