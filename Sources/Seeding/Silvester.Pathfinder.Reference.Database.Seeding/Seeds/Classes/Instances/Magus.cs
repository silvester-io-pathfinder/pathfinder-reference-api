using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Magus : Template
    {
        public static readonly Guid ID = Guid.Parse("34657e65-8a58-4802-8912-141c208ccc85");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Magus",
                BaseHealth = 8,

                Description = "Combining the physicality and technique of a warrior with the ability to cast arcane magic, you seek to perfect the art of fusing spell and strike. While the hefty tome you carry reflects hours conducting arcane research, your enemies need no reminder of your training. They recognize it as you take them down.",
                DuringCombatEncounters = "You channel spells through your weapon or body to hit enemies with a powerful attack and spell combination. Because your spells per day are limited, you often rely on trusty, carefully chosen cantrips and focus spells. When necessary, you know how to win a fight without magic.",
                DuringSocialEncounters = "Your education and breadth of experience make you knowledgeable about many subjects. You can contribute information related to your scholarly pursuits, especially about magic.",
                WhileExploring = "Your flexibility means you might look for magical auras, remain on guard, or even sneak around. Your ability to fill different niches means that your role often depends on the talents of the other members of your group.",
                InDowntime = "You split your time between magical pursuits, like researching spells and crafting items, and martial practice, such as retraining combat abilities to learn new techniques.",

                ClassDcProficiencyId = Proficiencies.Instances.Untrained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Trained.ID,

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
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,

                SpellAttackProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PredefinedMagicTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("9efa36c4-7c21-4a1f-bcd2-0531d1b4883c"), Text = "Continually refine your spell and item selections to suit your personal style, or prepare battle plans and spell lists for a variety of situations." };
            yield return new ClassMannerism { Id = Guid.Parse("2663c8c9-3218-44ed-8ed4-f486333d67f2"), Text = "Socialize with scholars of magic and veteran combatants alike, seeking out masters to teach you new techniques." };
            yield return new ClassMannerism { Id = Guid.Parse("0e9db3c5-f233-4863-879e-39078c77e0c2"), Text = "Overreach with ambitious plans that pull you in too many directions at once." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("d2adc27c-1b99-498a-adf9-8b1a0bc07f58"), Text = "Wonder how you can keep on top of two disparate disciplines at the same time." };
            yield return new ClassCharacteristic { Id = Guid.Parse("e3313e67-e41e-46d6-aa08-6f323414e53f"), Text = "Believe you have a broad enough skill set to take care of yourself in most situations." };
        }

        protected override Type GetClassFeaturesNamespace()
        {
            return typeof(ClassFeatures.Magusi.AbilityBoosts);
        }
    }
}
