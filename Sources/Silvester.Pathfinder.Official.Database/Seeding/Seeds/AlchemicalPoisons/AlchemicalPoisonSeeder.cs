using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalPoisons
{
    public class AlchemicalPoisonSeeder
    {
        public ModelBuilder Builder { get; }

        private Trait[] Traits { get; }

        private Bulk[] Bulks { get; }

        private SavingThrowStat[] SavingThrowStats { get; }
        
        private DamageType[] DamageTypes { get; }
        
        private ActionType[] ActionTypes { get; }

        public AlchemicalPoisonSeeder(ModelBuilder builder, Trait[] traits, Bulk[] bulks, SavingThrowStat[] savingThrowStats, DamageType[] damageTypes, ActionType[] actionTypes)
        {
            Builder = builder;
            Traits = traits;
            Bulks = bulks;
            SavingThrowStats = savingThrowStats;
            DamageTypes = damageTypes;
            ActionTypes = actionTypes;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractAlchemicalPoisonTemplate))))
            {
                AbstractAlchemicalPoisonTemplate template = (AbstractAlchemicalPoisonTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Bulk GetBulkByName(string name)
        {
            return Bulks.Filter((e) => e.Name, name).First();
        }

        public ActionType GetActionTypeByName(string name)
        {
            return ActionTypes.Filter((e) => e.Name, name).First();
        }

        public DamageType GetDamageTypeByName(string name)
        {
            return DamageTypes.Filter((e) => e.Name, name).First();
        }

        public SavingThrowStat GetSavingThrowStatByName(string name)
        {
            return SavingThrowStats.Filter((e) => e.Name, name).First();
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Traits.Filter((e) => e.Name, traitNames);
        }
    }
}
