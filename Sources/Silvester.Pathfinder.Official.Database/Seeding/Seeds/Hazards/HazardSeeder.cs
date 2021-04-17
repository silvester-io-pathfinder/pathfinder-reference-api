using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards
{
    public class HazardSeeder
    {
        public ModelBuilder Builder { get; }
        
        private Trait[] Traits { get; }
        
        private Source[] Sources { get; }
        
        private HazardImmunity[] Immunities { get; }

        private HazardComplexity[] Complexities { get; }
        
        private HazardType[] HazardTypes { get; }
        
        private AttackType[] AttackTypes { get; }
        
        private ActionType[] ActionTypes { get; }
        
        private DamageType[] DamageTypes { get; }

        private SavingThrowStat[] SavingThrowStats { get; }

        private Skill[] Skills { get; }

        private Proficiency[] Proficiencies{ get; }

        public HazardSeeder(ModelBuilder builder, Trait[] traits, Source[] sources, HazardImmunity[] immunities, HazardComplexity[] complexities, Skill[] skills, Proficiency[] proficiencies, HazardType[] types, AttackType[] attackTypes, ActionType[] actionTypes, DamageType[] damageTypes, SavingThrowStat[] savingThrowStats)
        {
            Builder = builder;
            Traits = traits;
            Sources = sources;
            Immunities = immunities;
            Complexities = complexities;
            Skills = skills;
            Proficiencies = proficiencies;
            HazardTypes = types;
            AttackTypes = attackTypes;
            ActionTypes = actionTypes;
            DamageTypes = damageTypes;
            SavingThrowStats = savingThrowStats;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractHazardTemplate))))
            {
                AbstractHazardTemplate template = (AbstractHazardTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Traits.Filter((e) => e.Name, traitNames);
        }

        public HazardImmunity[] FilterImmunities(params string[] traitNames)
        {
            return Immunities.Filter((e) => e.Name, traitNames);
        }

        public HazardComplexity GetComplexityByName(string name)
        {
            return Complexities.Filter((e) => e.Name, name).First();
        }

        public Skill GetSkillByName(string name)
        {
            return Skills.Filter((e) => e.Name, name).First();
        }

        public Proficiency GetProficiencyByName(string name)
        {
            return Proficiencies.Filter((e) => e.Name, name).First();
        }

        public HazardType GetHazardTypeByName(string name)
        {
            return HazardTypes.Filter((e) => e.Name, name).First();
        }

        public AttackType GetAttackTypeByName(string name)
        {
            return AttackTypes.Filter((e) => e.Name, name).First();
        }

        public ActionType GetActionTypeByName(string name)
        {
            return ActionTypes.Filter((e) => e.Name, name).First();
        }

        public Source GetSourceByName(string name)
        {
            return Sources.Filter((e) => e.Name, name).First();
        }

        public DamageType GetDamageTypeByName(string name)
        {
            return DamageTypes.Filter((e) => e.Name, name).First();
        }

        public SavingThrowStat GetSavingThrowStatByName(string name)
        {
            return SavingThrowStats.Filter((e) => e.Name, name).First();
        }
    }
}
