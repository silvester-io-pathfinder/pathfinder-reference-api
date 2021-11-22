using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Investigator : Template
    {
        public static readonly Guid ID = Guid.Parse("2483fb2b-b7cc-4eab-9c4e-0118477e46ed");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Investigator",
                BaseHealth = 8,

                Description = "You seek to uncover the truth, doggedly pursuing leads to reveal the plots of devious villains, discover ancient secrets, or unravel other mysteries. Your analytical mind quickly formulates solutions to complicated problems and your honed senses identify even the most obscure clues. Wielding knowledge as a weapon, you study the creatures and dangers you encounter to exploit their weaknesses.",
                DuringCombatEncounters = "Your keen insights regarding your foes make you more dangerous than your physical strength would suggest. After spending a moment to study your enemies, your perceptiveness allows you to act quickly, striking them where it hurts most. You often assist tougher members of your party, wisely protecting yourself while providing vital aid.",
                DuringSocialEncounters = "Few can stand up against your scrutiny. You might not be the most charming, but you see things for what they really are and develop an understanding of a social situation rapidly. Every conversation is an investigation, after all, and you never know what you might uncover!",
                WhileExploring = "You look for clues in your environment. You often prove yourself to be a valuable ally by serving as a party scout, analyzing the intricacies of puzzles or mysterious phenomena, and pursuing leads that could reveal beneficial information.",
                InDowntime = "You study up on subjects new and old, make new allies you can share information with, and pursue hobbies that keep your active mind satisfied. You might make a bit of coin on the side working as a private detective or consulting with the local constabulary.",

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
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("ac5fd47c-1575-4a05-8850-bd323519a40a"), Text = "Start asking questions—including several that are quite involved—immediately after you're presented with a conundrum." };
            yield return new ClassMannerism { Id = Guid.Parse("cf543469-df67-41eb-9738-90b0dd6cb22a"), Text = "Strive to uncover the deeper meanings behind anything you encounter and to identify the social machinations that truly drive events behind the scenes." };
            yield return new ClassMannerism { Id = Guid.Parse("5382ffaa-7a1a-4b92-80e9-556a58c966eb"), Text = "Get so involved in a case that you ignore other matters, deeming them trivial." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("17d41939-22da-493c-a121-452a8f5dba1c"), Text = "Find the cascades of information you spout forth extremely helpful, if difficult to fully comprehend." };
            yield return new ClassCharacteristic { Id = Guid.Parse("f4ce7778-674f-4ac4-9c81-69956c1872af"), Text = "Get a bit annoyed that you're such a know-it-all." };
            yield return new ClassCharacteristic { Id = Guid.Parse("ed7d4d66-8b4b-48a5-ab82-417677f36b9d"), Text = "Rely on you to solve mysteries, puzzles, or other challenges requiring intellectual curiosity and reasoning." };
        }

        protected override Type GetClassFeaturesNamespace()
        {
            return typeof(ClassFeatures.Investigators.AbilityBoosts);
        }
    }
}
