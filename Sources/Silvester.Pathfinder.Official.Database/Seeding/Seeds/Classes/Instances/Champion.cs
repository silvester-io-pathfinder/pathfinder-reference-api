using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes.Instances
{
    public class Champion : AbstractClassTemplate
    {
        public static readonly Guid ID = Guid.Parse("3f3362c2-09a1-47da-8945-cea25e313f80");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Champion",
                BaseHealth = 10,

                Description = "You are an emissary of a deity, a devoted servant who has taken up a weighty mantle, and you adhere to a code that holds you apart from those around you. While champions exist for every alignment, as a champion of good, you provide certainty and hope to the innocent. You have powerful defenses that you share freely with your allies and innocent bystanders, as well as holy power you use to end the threat of evil. Your devotion even attracts the attention of holy spirits who aid you on your journey.",
                DuringCombatEncounters = "You confront enemies in hand-to-hand combat while carefully positioning yourself to protect your allies.",
                DuringSocialEncounters = "You are a voice of hope, striving to reach a peaceful solution that strengthens bonds and yields good results for all.",
                WhileExploring = "You overcome barriers both physical and spiritual, providing inspiration to your allies through your actions and—when your fellow adventurers ask for it—providing moral and ethical guidance.",
                InDowntime = "You spend much of your time in solemn prayer and contemplation, rigorous training, charity work, and fulfilling the tenets of your code, but that doesn’t mean there isn’t time to take up a craft or hobby.",

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
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
                HeavyArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellAttackProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PredefinedMagicTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("5a4bfb01-6a81-4d56-b4a0-20b0d3caf405"), Text = "Believe there is always hope that good will triumph over evil, no matter how grim the odds." };
            yield return new ClassMannerism { Id = Guid.Parse("5b4f9efb-8fe3-45a3-ab30-c5ea31fb37e3"), Text = "Know the ends don’t justify the means, since evil acts increase the power of evil." };
            yield return new ClassMannerism { Id = Guid.Parse("7752d7ec-e22e-4d95-b0eb-e41113a8a8a6"), Text = "Have a strong sense of right and wrong, and grow frustrated when greed or shortsightedness breeds evil." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("42ac891a-1c2f-4751-84cd-e0b8ee6c8140"), Text = "See you as a symbol of hope, especially in a time of great need." };
            yield return new ClassCharacteristic { Id = Guid.Parse("9030eece-2379-444d-b633-c9095ff74139"), Text = "Worry you secretly despise them for not living up to your impossible standard, or that you are unwilling to compromise when necessary." };
            yield return new ClassCharacteristic { Id = Guid.Parse("3b024cdb-5520-43de-8e41-82659ad63dfb"), Text = "Know that you’ve sworn divine oaths of service they can trust you to keep." };
        }
    }
}
