using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Cleric : Template
    {
        public static readonly Guid ID = Guid.Parse("f7cb4156-4ec7-4c78-bd28-4db83a0f5ade");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Cleric",
                BaseHealth = 8,

                Description = "Deities work their will upon the world in infinite ways, and you serve as one of their most stalwart mortal servants. Blessed with divine magic, you live the ideals of your faith, adorn yourself with the symbols of your church, and train diligently to wield your deity’s favored weapon. Your spells might protect and heal your allies, or they might punish foes and enemies of your faith, as your deity wills. Yours is a life of devotion, spreading the teachings of your faith through both word and deed.",
                DuringCombatEncounters = "If you’re a warpriest, you balance between casting spells and attacking with weapons, typically the favored weapon of your deity. If you’re a cloistered cleric, you primarily cast spells. Most of your spells can boost, protect, or heal your allies. Depending on your deity, you get extra spells to heal your allies or harm your enemies.",
                DuringSocialEncounters = "You might make diplomatic overtures or deliver impressive speeches. Because you’re wise, you also pick up on falsehoods others tell.",
                WhileExploring = "You detect nearby magic and interpret any religious writing you come across. You might also concentrate on a protective spell for your allies in case of attack.After a battle or hazard, you might heal anyone who was hurt.",
                InDowntime = "You might perform services at a temple, travel to spread the word of your deity, research scripture, celebrate holy days, or even found a new temple.",

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
                SpellDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PredefinedMagicTraditionId = MagicTraditions.Instances.Divine.ID
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse("ebb75ed7-bfa4-40c5-8bb4-3f19794d2a70"), Text = "Visit the temples and holy places sacred to your faith, and have an immediate affinity with other worshippers of your deity." };
            yield return new ClassMannerism { Id = Guid.Parse("1be1a716-5449-4961-893d-67e7a4e84269"), Text = "Know the teachings of your religion’s holy texts and how they apply to a dilemma." };
            yield return new ClassMannerism { Id = Guid.Parse("6a44f1c6-54c0-49ea-a3cc-8c61d3096138"), Text = "Cooperate with your allies, provided they don’t ask you to go against divine will." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse("8723a71e-24b5-49b5-8357-b36acc8a68ad"), Text = "Find your devotion impressive, even if they don’t understand it." };
            yield return new ClassCharacteristic { Id = Guid.Parse("a2e4b7a8-09ed-47f3-8f09-3d87b28c56d4"), Text = "Expect you to heal their wounds." };
            yield return new ClassCharacteristic { Id = Guid.Parse("747f91ce-3349-4317-bc31-2ad6be7fa6c6"), Text = "Rely on you to interact with other religious figures." };
        }

        protected override Type GetClassFeaturesNamespace()
        {
            return typeof(ClassFeatures.Clerics.AbilityBoosts);
        }
    }
}
