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

        
        /*protected override IEnumerable<ClassFeature> GetFeatures(ClassSeeder seeder)
        {
            yield return new ClassFeature { Id = Guid.Parse("f236838d-30f7-447c-a847-4bdbf8d0ff55"), Level = 1, Name = "Ancestry and Background", Description = "In addition to the abilities provided by your class at 1st level, you have the benefits of your selected ancestry and background, as described in Chapter 2." };
            yield return new ClassFeature { Id = Guid.Parse("7038a2d6-69b3-4f15-b967-3d0520f53b6b"), Level = 1, Name = "Initial Proficiencies", Description = "At 1st level you gain a number of proficiencies that represent your basic training. These proficiencies are noted at the start of this class." };
            yield return new ClassFeature { Id = Guid.Parse("94a9dd2d-ded9-448f-9c54-6ad3cd89c62c"), Level = 1, Name = "Attack of Opportunity", Description = "Ever watchful for weaknesses, you can quickly attack foes that leave an opening in their defenses. You gain the Attack of Opportunity reaction." };
            yield return new ClassFeature { Id = Guid.Parse("4c32a418-a7c1-4560-9dd7-c4f487f82845"), Level = 1, Name = "Fighter Feats", Description = "At 1st level and every even-numbered level thereafter, you gain a fighter class feat. Fighter class feats are described beginning on page 144." };
            yield return new ClassFeature { Id = Guid.Parse("4d622476-372f-4bb8-b45b-39af89995c15"), Level = 1, Name = "Shield Block", Description = "You gain the Shield Block general feat (found on page 266), a reaction that lets you reduce damage with your shield." };
            yield return new ClassFeature { Id = Guid.Parse("c6759034-e191-4829-9ace-d30830c55462"), Level = 2, Name = "Skill Feats", Description = "skill feat. Skill feats can be found in Chapter 5 and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
            yield return new ClassFeature { Id = Guid.Parse("04d951f7-e500-44a5-942b-0f078a942cba"), Level = 3, Name = "Bravery", Description = "Having faced countless foes and the chaos of battle, you have learned how to stand strong in the face of fear and keep on fighting. Your proficiency rank for Will saves increases to expert. When you roll a success at a Will save against a fear effect, you get a critical success instead. In addition, anytime you gain the frightened condition, reduce its value by 1." };
            yield return new ClassFeature { Id = Guid.Parse("19c05b36-d436-4a24-92dc-492d9e19a054"), Level = 3, Name = "General Feats", Description = "At 3rd level and every 4 levels thereafter, you gain a general feat. General feats are listed in Chapter 5." };
            yield return new ClassFeature { Id = Guid.Parse("13a385db-cf74-4afa-ba62-a8e8d82eba4e"), Level = 3, Name = "Skill Increases", Description = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this increase either to increase your proficiency rank to trained in one skill you’re untrained in, or to increase your proficiency rank in one skill in which you’re already trained to expert. At 7th level, you can use skill increases to increase your proficiency rank to master in a skill in which you’re already an expert, and at 15th level, you can use them to increase your proficiency rank to legendary in a skill in which you’re already a master." };
            yield return new ClassFeature { Id = Guid.Parse("3461b971-084a-45b3-9fc2-0e311628c76c"), Level = 5, Name = "Ability Boosts", Description = "At 5th level and every 5 levels thereafter, you boost four different ability scores. You can use these ability boosts to increase your ability scores above 18. Boosting an ability score increases it by 1 if it’s already 18 or above, or by 2 if it starts out below 18." };
            yield return new ClassFeature { Id = Guid.Parse("ae00fbcf-4c77-493c-a012-25d628a33a96"), Level = 5, Name = "Ancestry Feats", Description = "In addition to the ancestry feat you started with, you gain an ancestry feat at 5th level and every 4 levels thereafter. The list of ancestry feats available to you can be found in your ancestry’s entry in Chapter 2." };
            yield return new ClassFeature { Id = Guid.Parse("2f956dd8-cf61-4fb3-a927-ed3794a919c9"), Level = 5, Name = "Fighter Weapon Mastery", Description = "Hours spent training with your preferred weapons, learning and developing new combat techniques, have made you particularly effective with your weapons of choice. Choose one weapon group. Your proficiency rank increases to master with the simple weapons, martial weapons, and unarmed attacks in that group, and to expert with the advanced weapons in that group. You gain access to the critical specialization effects (page 283) of all weapons and unarmed attacks for which you have master proficiency." };
            yield return new ClassFeature { Id = Guid.Parse("be04dc17-5ac1-47e8-aa9e-59d24f8507dd"), Level = 7, Name = "Battlefield Surveyor", Description = "Whether taking stock of an enemy army or simply standing guard, you excel at observing your foes. Your proficiency rank for Perception increases to master. In addition, you gain a +2 circumstance bonus to Perception checks for initiative, making you faster to react during combat." };
            yield return new ClassFeature { Id = Guid.Parse("db85d813-e98d-4a46-b0f4-789154345962"), Level = 7, Name = "Weapon Specialization", Description = "You’ve learned how to inflict greater injuries with the weapons you know best. You deal 2 additional damage with weapons and unarmed attacks in which you are an expert. This damage increases to 3 if you’re a master, and to 4 if you’re legendary." };
            yield return new ClassFeature { Id = Guid.Parse("77dc439a-0c98-4612-a98e-2ced7528df8f"), Level = 9, Name = "Combat Flexibility", Description = "Through your experience in battle, you can prepare your tactics to suit different situations. When you make your daily preparations, you gain one fighter feat of 8th level or lower that you don’t already have. You can use that feat until your next daily preparations. You must meet all of the feat’s other prerequisites." };
            yield return new ClassFeature { Id = Guid.Parse("8a8b2008-bfef-4c04-b3b2-e4ecdef7b043"), Level = 9, Name = "Juggernaut", Description = "Your body is accustomed to physical hardship and resistant to ailments. Your proficiency rank for Fortitude saves increases to master. When you roll a success on a Fortitude save, you get a critical success instead." };
            yield return new ClassFeature { Id = Guid.Parse("0b9db322-65c4-4391-9740-ba11960aa0e4"), Level = 11, Name = "Armor Expertise", Description = "You have spent so much time wearing armor that you know how to make the most of its protection. Your proficiency rank for light, medium, and heavy armor, as well as for unarmored defense, increase to expert. You gain the armor specialization effects of medium and heavy armor." };
            yield return new ClassFeature { Id = Guid.Parse("fb8a6efc-36f9-4821-901a-e810cc2a5f15"), Level = 11, Name = "Fighter Expertise", Description = "Your practiced techniques are hard to resist. Your proficiency rank for your fighter class DC increases to expert." };
            yield return new ClassFeature { Id = Guid.Parse("1ba85fbd-f31c-4772-925f-f55471d5745d"), Level = 13, Name = "Weapon Legend", Description = "You’ve learned fighting techniques that apply to all armaments, and you’ve developed unparalleled skill with your favorite weapons. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to master. Your proficiency rank for advanced weapons increases to expert. You can select one weapon group and increase your proficiency ranks to legendary for all simple weapons, martial weapons, and unarmed attacks in that weapon group, and to master for all advanced weapons in that weapon group." };
            yield return new ClassFeature { Id = Guid.Parse("96faf1b0-7696-4360-9bdd-6e7d2b2b8d83"), Level = 15, Name = "Evasion", Description = "You’ve learned to move quickly to avoid explosions, a dragon’s breath, and worse. Your proficiency rank for Reflex saves increases to master. When you roll a success on a Reflex save, you get a critical success instead." };
            yield return new ClassFeature { Id = Guid.Parse("4229b434-7722-4f0e-a574-f1cb295465a4"), Level = 15, Name = "Greater Weapon Specialization", Description = "Your damage from weapon specialization increases to 4 with weapons and unarmed attacks in which you’re an expert, 6 if you’re a master, and 8 if you’re legendary." };
            yield return new ClassFeature { Id = Guid.Parse("65816f89-4f18-4290-bc90-759f7f329b12"), Level = 15, Name = "Improved Flexibility", Description = "Your extensive experience gives you even greater ability to adapt to each day’s challenges. When you use combat flexibility, you can gain two fighter feats instead of one. While the first feat must still be 8th level or lower, the second feat can be up to 14th level, and you can use the first feat to meet the prerequisites of the second feat. You must meet all of the feats’ prerequisites." };
            yield return new ClassFeature { Id = Guid.Parse("74ffc198-a1a2-4052-b60c-821f7d144c15"), Level = 17, Name = "Armor Mastery", Description = "Your skill with armor improves, increasing your ability to prevent blows. Your proficiency ranks for light, medium, and heavy armor, as well as for unarmored defense, increase to master." };
            yield return new ClassFeature { Id = Guid.Parse("52de8174-205e-41fe-8add-9b54c57ed919"), Level = 19, Name = "Versatile Legend", Description = "You are nigh-unmatched with any weapon. Your proficiency ranks for simple weapons, martial weapons, and unarmed attacks increase to legendary, and your proficiency rank for advanced weapons increases to master. Your proficiency rank for your fighter class DC increases to master." };
        }*/
    }
}
