using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Sorcerer : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("05d42777-0744-4a72-85ad-d27186c96deb");

        protected override Class GetClass()
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
                LightArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,

                SpellAttackProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("e076f25a-3cf1-48f2-a7a5-83671f564522"), Text = "Have a strong independent streak, and whether you embrace or reject your magical heritage, you long to distinguish yourself both as a spellcaster and as an individual." };
            yield return new ClassMannerism { Id = Guid.Parse("ca503052-4fc3-4997-ac3e-3c5f70a15ec3"), Text = "View your lineage with fascination, fear, or something in between—anything from wholehearted acceptance to vehement rejection." };
            yield return new ClassMannerism { Id = Guid.Parse("8f31f877-c43f-493f-a6cb-9db65fba60cb"), Text = "Rely on magic items, such as scrolls and wands, to supplement your limited selection of spells." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("9266174a-c40c-4aa9-a834-44c58fde1056"), Text = "Marvel at your ability to create magic from thin air and view your abilities with equal parts admiration and mistrust." };
            yield return new ClassCharacteristic { Id = Guid.Parse("3844b3a3-6ece-44f4-aa24-3da8c2a50ce1"), Text = "Consider you less dedicated than studious wizards, devoted clerics, and other practitioners of magic, since power comes to you naturally." };
            yield return new ClassCharacteristic { Id = Guid.Parse("417aafb9-414d-44cd-834f-a41bd953f331"), Text = "Assume you’re as unpredictable as the magic you bring forth, even if your personality proves otherwise." };
        }
    }
}
