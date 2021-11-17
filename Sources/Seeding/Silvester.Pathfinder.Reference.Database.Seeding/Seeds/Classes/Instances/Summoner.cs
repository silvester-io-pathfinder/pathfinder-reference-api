using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Summoner : Template
    {
        public static readonly Guid ID = Guid.Parse("9a55bcf0-5def-42ab-996e-77ac15fbb864");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Summoner",
                BaseHealth = 10,

                Description = "You can magically beckon a powerful being called an eidolon to your side, serving as the mortal conduit that anchors it to the world. Whether your eidolon is a friend, a servant, or even a personal god, your connection to it marks you as extraordinary, shaping the course of your life dramatically",
                DuringCombatEncounters = "You and your eidolon fight together as one. You can rely on your eidolon for mundane challenges, saving your spells for when they're needed most.",
                DuringSocialEncounters = "Your powerful personality allows you to take the lead when negotiating. You and your eidolon might engage with others in different ways, but even if your guardian remains silent, its presence reminds those around you of your power.",
                WhileExploring = "Whether you remain on alert for the presence of strange magic or keep an eye out for trouble, you and your eidolon act together to cover more ground, pool your knowledge, and leverage each other's abilities.",
                InDowntime = "You might attempt to learn more about the nature of your eidolon and delve deeper into the secrets of its magical tradition to Learn a Spell, Craft magic items with your eidolon's help, or make allies using your social skills.",

                ClassDcProficiencyId = Proficiencies.Instances.Untrained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Trained.ID,

                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
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
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("18acb0ba-af64-4788-bfae-e383e38fb696"), Text = "Rely on your eidolon to accomplish physical tasks while you handle the mental ones." };
            yield return new ClassMannerism { Id = Guid.Parse("23813a4b-d56b-43d5-94bc-6caa5616a7c7"), Text = "Develop attitudes and mannerisms in line with your eidolon's way of thinking, even as your nature shapes its behavior." };
            yield return new ClassMannerism { Id = Guid.Parse("e6bd3d18-93b3-40b9-a5ae-16b45558fbb2"), Text = "Consider your eidolon a close friend, a guiding figure, a protector, or a rival bound to you." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("3e3888f8-8fef-4c71-b108-25f0df360a49"), Text = "Feel safe with you (and your eidolon) at their side." };
            yield return new ClassCharacteristic { Id = Guid.Parse("ca4c922c-3804-4b40-9b6b-d55d851a1dde"), Text = "Expect that since you know information about your eidolon, you might know details about other sorts of strange monsters." };
            yield return new ClassCharacteristic { Id = Guid.Parse("ce12e391-e771-44ed-ab40-9d3cf3b14e86"), Text = "View you with awe or fear because of the powerful, strange creature that accompanies you." };
        }

        protected override Type GetClassFeaturesNamespace()
        {
            return typeof(ClassFeatures.Summoners.AbilityBoosts);
        }
    }
}
