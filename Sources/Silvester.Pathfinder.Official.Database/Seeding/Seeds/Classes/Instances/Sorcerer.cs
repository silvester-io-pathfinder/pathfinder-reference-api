using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Sorcerer : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("05d42777-0744-4a72-85ad-d27186c96deb");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Sorcerer",
                BaseHealth = 6,

                Description = "You didn’t choose to become a spellcaster—you were born one. There’s magic in your blood, whether a divinity touched one of your ancestors, a forebear communed with a primal creature, or a powerful occult ritual influenced your line. Self-reflection and study allow you to refine your inherent magical skills and unlock new, more powerful abilities. The power in your blood carries a risk, however, and you constantly face the choice of whether you’ll rise to become a master spellcaster or fall into destruction.",
                DuringCombatEncounters = "You use spells to injure your enemies, influence their minds, and hamper their movements. You might be too vulnerable to get into melee combat, or your bloodline might give you abilities that help you hold your own in a brawl. While your magic is powerful, to conserve your best spells—or when you’ve used them all up—you also rely on cantrips.",
                DuringSocialEncounters = "Your natural charisma makes you good at interacting with people.",
                WhileExploring = "You detect the magic around you, finding treasures and warning your adventuring group of magical traps. When the group encounters mysteries or problems related to your bloodline, you try to solve them.",
                InDowntime = "You craft magic items or scribe scrolls. Your bloodline might drive you to research your ancestry or associate with affiliated people or creatures.",

                ClassDcProficiencyId = seeder.GetProficiency("Untrained"),
                PerceptionProficiencyId = seeder.GetProficiency("Trained"),

                FortitudeProficiencyId = seeder.GetProficiency("Trained"),
                ReflexProficiencyId = seeder.GetProficiency("Trained"),
                WillProficiencyId = seeder.GetProficiency("Expert"),

                SimpleWeaponProficiencyId = seeder.GetProficiency("Trained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),

                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Untrained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Untrained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained"),

                SpellAttackProficiencyId = seeder.GetProficiency("Trained"),
                SpellDcProficiencyId = seeder.GetProficiency("Trained")
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Charisma");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Have a strong independent streak, and whether you embrace or reject your magical heritage, you long to distinguish yourself both as a spellcaster and as an individual." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "View your lineage with fascination, fear, or something in between—anything from wholehearted acceptance to vehement rejection." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Rely on magic items, such as scrolls and wands, to supplement your limited selection of spells." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Marvel at your ability to create magic from thin air and view your abilities with equal parts admiration and mistrust." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Consider you less dedicated than studious wizards, devoted clerics, and other practitioners of magic, since power comes to you naturally." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Assume you’re as unpredictable as the magic you bring forth, even if your personality proves otherwise." };
        }
    }
}
