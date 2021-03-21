using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Wizard : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("0e53c45a-9ab8-4d4a-bb5b-51af257c56bc");

        protected override Class GetClass(ClassSeeder seeder)
        {
            return new Class
            {
                Id = ID,
                Name = "Wizard",
                BaseHealth = 6,

                Description = "You are an eternal student of the arcane secrets of the universe, using your mastery of magic to cast powerful and devastating spells. You treat magic like a science, cross-referencing the latest texts on practical spellcraft with ancient esoteric tomes to discover and understand how magic works. Yet magical theory is vast, and there’s no way you can study it all. You either specialize in one of the eight schools of magic, gaining deeper understanding of the nuances of those spells above all others, or favor a broader approach that emphasizes the way all magic comes together at the expense of depth.",
                DuringCombatEncounters = "You likely try to stay out of the fray, carefully judging when to use your spells. You save your most powerful magic to incapacitate threatening foes and use your cantrips when only weaker foes remain. When enemies pull out tricks like invisibility or flight, you answer with spells like glitterdust or earth bind, leveling the field for your allies.",
                DuringSocialEncounters = "You provide a well of knowledge about arcane matters and solve arguments with logic.",
                WhileExploring = "You locate magical auras and determine the arcane significance of magical writing or phenomena you uncover. When you run across an unusual obstacle to further exploration, you probably have a scroll that will make it easier to overcome.",
                InDowntime = "You learn new spells, craft magic items, or scribe scrolls for your party, and seek out new and exciting formulas in addition to spells. You might even forge scholarly connections and establish a school or guild of your own.",

                ClassDcProficiencyId = seeder.GetProficiency("Untrained"),
                PerceptionProficiencyId = seeder.GetProficiency("Trained"),

                FortitudeProficiencyId = seeder.GetProficiency("Trained"),
                ReflexProficiencyId = seeder.GetProficiency("Trained"),
                WillProficiencyId = seeder.GetProficiency("Expert"),

                SimpleWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                MartialWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                AdvancedWeaponProficiencyId = seeder.GetProficiency("Untrained"),
                UnarmedWeaponProficiencyId = seeder.GetProficiency("Trained"),

                UnarmoredProficiencyId = seeder.GetProficiency("Trained"),
                LightArmorProficiencyId = seeder.GetProficiency("Untrained"),
                MediumArmorProficiencyId = seeder.GetProficiency("Untrained"),
                HeavyArmorProficiencyId = seeder.GetProficiency("Untrained"),

                SpellAttackProficiencyId = seeder.GetProficiency("Trained"),
                SpellDcProficiencyId = seeder.GetProficiency("Trained"),
                PredefinedMagicTraditionId = seeder.GetMagicTradition("Arcane")
            };
        }

        protected override IEnumerable<Stat> GetKeyAbilities(ClassSeeder seeder)
        {
            return seeder.FilterStats("Intelligence");
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms(ClassSeeder seeder)
        {
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Have an unquenchable intellectual curiosity about how everything in the world around you works—magic in particular." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Believe fervently that your school of magic is superior (if you’re a specialist) or that true mastery of magic requires knowledge of all schools(if you’re a universalist)." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Use esoteric jargon and technical terms to precisely describe the minutiae of magical effects, even though the difference is probably lost on other people." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics(ClassSeeder seeder)
        {
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Consider you to be incredibly powerful and potentially dangerous." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Fear what your magic can do to their minds, bodies, and souls, and ask that you avoid casting spells in polite company, as few can identify whether one of your spells is harmless or malevolent until it’s too late." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Assume you can easily solve all their problems, from dangerous weather to poor crop yields, and ask you for spells that can help them get whatever they desire." };
        }
    }
}
