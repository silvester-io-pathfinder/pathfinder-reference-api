using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Swashbuckler : Template
    {
        public static readonly Guid ID = Guid.Parse("deb62736-af71-4600-bd4b-59e55961b74d");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Swashbuckler",
                BaseHealth = 10,

                Description = "Many warriors rely on brute force, weighty armor, or cumbersome weapons. For you, battle is a dance where you move among foes with style and grace. You dart among combatants with flair and land powerful finishing moves with a flick of the wrist and a flash of the blade, all while countering attacks with elegant ripostes that keep enemies off balance. Harassing and thwarting your foes lets you charm fate and cheat death time and again with aplomb and plenty of flair.",
                DuringCombatEncounters = "You show off to gain panache, leveraging your flair to build up to powerful finishing moves. You stay nimble, moving into the best position to perform your maneuvers while dodging enemy blows and responding with swift ripostes. Depending on your swashbuckler’s style, you might dance among your foes; slip past their defenses; or beguile, distract, or frighten them.",
                DuringSocialEncounters = "You are equally likely to charm or intimidate others—or both. You might be an adept socialite, or you might create distractions for others who do the talking.",
                WhileExploring = "You keep a careful eye on your surroundings and other people, always prepared to leap into action with bravado and flair. You interact with the environment in bold, sweeping strokes rather than skulking to avoid detection.",
                InDowntime = "You might carouse at the tavern, repair and maintain your armaments, or train to learn new techniques. To maintain your impressive reputation, you might build an organization in your name or establish a following of admirers.",

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Expert.ID,

                FortitudeProficiencyId = Proficiencies.Instances.Trained.ID,
                ReflexProficiencyId = Proficiencies.Instances.Expert.ID,
                WillProficiencyId = Proficiencies.Instances.Expert.ID,

                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,

                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("f4565e71-6154-49e4-b152-9e67df99750b"), Text = "Portray yourself as a heroic daredevil or a roguish braggart, knowing you can live up to the image you present." };
            yield return new ClassMannerism { Id = Guid.Parse("fde67e42-2e4a-4abc-9bb4-e84e70a4cc18"), Text = "Hold yourself in high esteem, confident in your abilities and your reputation." };
            yield return new ClassMannerism { Id = Guid.Parse("d2983995-904d-4f96-a4ce-55abbefbd81b"), Text = "Practice your skills and maneuvers regularly to ensure you never grow rusty." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("1c6d2032-af7f-4685-8eae-868aa5711e2e"), Text = "Admire your theatrics, bravado, and skill with a blade." };
            yield return new ClassCharacteristic { Id = Guid.Parse("0b8205e3-3820-4e28-b3e1-e4ead143b5ce"), Text = "Find you arrogant unless they know you well enough to appreciate your style." };
            yield return new ClassCharacteristic { Id = Guid.Parse("29f951f9-21c2-4063-bbaf-4c2b227cf204"), Text = "Underestimate how much of a threat you pose until they face the end of your deadly blade." };
        }

        protected override Type GetClassFeaturesNamespace()
        {
            return typeof(ClassFeatures.Swashbucklers.AbilityBoosts);
        }
    }
}
