using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Gunslinger : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Gunslinger",
                BaseHealth = 8,

                Description = "While some fear projectile weapons, you savor the searing flash, wild kick, and cloying smoke that accompanies a gunshot, or snap of the cable and telltale thunk of your crossbow just before your bolt finds purchase. Ready to draw a bead on an enemy at every turn, you rely on your reflexes, steady hand, and knowledge of your weapons to riddle your foes with holes.",
                DuringCombatEncounters = "You strike from range with your firearms, seeking to defeat your opponents before they can pose a true threat. Depending on your choice of weapon, you might prefer to strike your opponent from a hidden position before they ever realize you're there, dash through a frenzied melee with pistols blazing, or glide effortlessly across the battlefield, waiting for the perfect moment to end the conflict with a single, well-placed shot.",
                DuringSocialEncounters = "You have a keen eye and can see things coming from farther than most. You might not be the life of the party, but your companions know to pay attention when your subtle nod or concerned grunt indicates that something's amiss.",
                WhileExploring = "You scout the group's position for incoming threats and help search for secret doors and hidden passages, keeping a weather eye out for unexpected threats.",
                InDowntime = "You might craft ammunition or keep your complex weapons clean and maintained, and you might look for work that matches your unique talents, such as working as a blacksmith, engineer, or part of the local watch. You might wander from town to town, or stay put for a spell to enjoy the silence that lingers between gunfights.",

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Expert.ID,

                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
                ReflexProficiencyId = Proficiencies.Instances.Expert.ID,
                WillProficiencyId = Proficiencies.Instances.Trained.ID,

                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,

                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Seek out areas of great conflict where your unique choice of weaponry can help build your reputation." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Explore new horizons, trusting your honed senses and deadly weapon to keep you safe." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Demonstrate extensive knowledge about various types of guns and ammunition, along with curiosity about the latest in gun technology." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Assume that since you know how your gun works, you must also understand how to resolve other mechanical challenges." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Underestimate you at first glance, thinking you rely on your gun because you lack any other skills." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Respect your eternal vigilance, unyielding grit, and excellent aim." };
        }
    }
}
