using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Diseases
{
    public class DiseaseSeeder
    {
        public ModelBuilder Builder { get; }

        private Trait[] Traits { get; }

        private SavingThrowStat[] SavingThrowStats { get; }

        private DamageType[] DamageTypes { get; }

        public DiseaseSeeder(ModelBuilder builder,  Trait[] traits, SavingThrowStat[] savingThrowStats, DamageType[] damageTypes)
        {
            Builder = builder;
            Traits = traits;
            SavingThrowStats = savingThrowStats;
            DamageTypes = damageTypes;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractDiseaseTemplate))))
            {
                AbstractDiseaseTemplate template = (AbstractDiseaseTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Traits.Filter(e => e.Name, traitNames);
        }

        public SavingThrowStat GetSavingThrowStatByName(string name)
        {
            return SavingThrowStats.Filter((e) => e.Name, name).First();
        }

        public DamageType GetDamageTypeByName(string name)
        {
            return DamageTypes.Filter((e) => e.Name, name).First();
        }
    }
}
