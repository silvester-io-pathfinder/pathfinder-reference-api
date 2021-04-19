using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalBombs
{
    public class AlchemicalBombSeeder
    {
        public ModelBuilder Builder { get; }

        private Trait[] Traits { get; }
        
        private Bulk[] Bulks { get; }
        
        private PotionPotency[] PotionPotencies { get; }

        public AlchemicalBombSeeder(ModelBuilder builder, Trait[] traits, Bulk[] bulks, PotionPotency[] potionPotencies)
        {
            Builder = builder;
            Traits = traits;
            Bulks = bulks;
            PotionPotencies = potionPotencies;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractAlchemicalBombTemplate))))
            {
                AbstractAlchemicalBombTemplate template = (AbstractAlchemicalBombTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Bulk GetBulkByName(string name)
        {
            return Bulks.Filter((e) => e.Name, name).First();
        }

        public PotionPotency GetPotionPotencyByName(string name)
        {
            return PotionPotencies.Filter((e) => e.Name, name).First();
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Traits.Filter((e) => e.Name, traitNames);
        }
    }
}
