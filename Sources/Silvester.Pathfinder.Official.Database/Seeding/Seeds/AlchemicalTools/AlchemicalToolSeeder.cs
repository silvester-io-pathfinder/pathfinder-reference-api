using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools
{
    public class AlchemicalToolSeeder
    {
        public ModelBuilder Builder { get; }

        private Trait[] Traits { get; }

        private Bulk[] Bulks { get; }

        private AlchemicalToolPotency[] AlchemicalToolPotencies { get; }
        
        private ActionType[] ActionTypes { get; }

        public AlchemicalToolSeeder(ModelBuilder builder, Trait[] traits, Bulk[] bulks, AlchemicalToolPotency[] alchemicalToolPotencies, ActionType[] actionTypes)
        {
            Builder = builder;
            Traits = traits;
            Bulks = bulks;
            AlchemicalToolPotencies = alchemicalToolPotencies;
            ActionTypes = actionTypes;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractAlchemicalToolTemplate))))
            {
                AbstractAlchemicalToolTemplate template = (AbstractAlchemicalToolTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Bulk GetBulkByName(string name)
        {
            return Bulks.Filter((e) => e.Name, name).First();
        }

        public AlchemicalToolPotency GetAlchemicalToolPotencyByName(string name)
        {
            return AlchemicalToolPotencies.Filter((e) => e.Name, name).First();
        }

        public ActionType GetActionTypeByName(string name)
        {
            return ActionTypes.Filter((e) => e.Name, name).First();
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Traits.Filter((e) => e.Name, traitNames);
        }
    }
}
