using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Fighter : Template
    {
        public static readonly Guid ID = Guid.Parse("9cace213-82ff-4751-a438-8afd87d433e4");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Fighter",
                BaseHealth = 10,

                Description = "Fighting for honor, greed, loyalty, or simply the thrill of battle, you are an undisputed master of weaponry and combat techniques. You combine your actions through clever combinations of opening moves, finishing strikes, and counterattacks whenever your foes are unwise enough to drop their guard. Whether you are a knight, mercenary, sharpshooter, or blade master, you have honed your martial skills into an art form and perform devastating critical attacks on your enemies.",
                DuringCombatEncounters = "You strike with unmatched accuracy and use specialized combat techniques. A melee fighter stands between allies and enemies, attacking foes who try to get past. A ranged fighter delivers precise shots from a distance.",
                DuringSocialEncounters = "You can be an intimidating presence. This can be useful when negotiating with enemies, but is sometimes a liability in more genteel interactions.",
                WhileExploring = "You keep up your defenses in preparation for combat, and keep an eye out for hidden threats. You also overcome physical challenges in your way, breaking down doors, lifting obstacles, climbing adeptly, and leaping across pits.",
                InDowntime = "You might perform manual labor or craft and repair armaments. If you know techniques you no longer favor, you might train yourself in new ones. If you’ve established your reputation, you might build an organization or a stronghold of your own.",

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Expert.ID,
                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
                ReflexProficiencyId = Proficiencies.Instances.Expert.ID,
                WillProficiencyId = Proficiencies.Instances.Trained.ID,
                SimpleWeaponProficiencyId = Proficiencies.Instances.Expert.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Expert.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Expert.ID,
                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                SpellAttackProficiencyId = Proficiencies.Instances.Untrained.ID,
                SpellDcProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Dexterity.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("c65bfa42-aaad-401e-a6ad-2fa61272635d"), Text = "Know the purpose and quality of every weapon and piece of armor you own." };
            yield return new ClassMannerism { Id = Guid.Parse("0ddc24b5-5b32-433f-9468-1e07d0c05483"), Text = "Recognize that the danger of an adventurer’s life must be balanced out with great revelry or ambitious works." };
            yield return new ClassMannerism { Id = Guid.Parse("e0e2f9fc-a9d3-4d41-be08-999ba0878101"), Text = "Have little patience for puzzles or problems that require detailed logic or study." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("34c4e6c1-937c-475e-ba53-bdfcdd4d6d0d"), Text = "Find you intimidating until they get to know you, and maybe even after they get to know you." };
            yield return new ClassCharacteristic { Id = Guid.Parse("fe9a7547-e4df-455a-a33c-00634db55fde"), Text = "Expect you’re all brawn and no brains." };
            yield return new ClassCharacteristic { Id = Guid.Parse("29d18b56-1b93-456b-9a0e-a0189bd86dbf"), Text = "Respect your expertise in the art of warfare and value your opinion on the quality of armaments." };
        }

        protected override Type GetClassFeaturesNamespace()
        {
            return typeof(ClassFeatures.Fighters.AbilityBoosts);
        }
    }
}
