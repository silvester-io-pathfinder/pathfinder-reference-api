using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes
{
    public class ActionSeeder
    {
        public ModelBuilder Builder { get; }

        public ActionType[] ActionTypes { get; }

        public Trait[] Traits { get; }

        public ActionSeeder(ModelBuilder builder, ActionType[] actionTypes, Trait[] traits)
        {
            Builder = builder;
            ActionTypes = actionTypes;
            Traits = traits;
        }

        public Guid GetActionType(string name)
        {
            return ActionTypes.Filter(e => e.Name, new[] { name })[0].Id;
        }

        public Trait GetTrait(string name)
        {
            return Traits.Filter(e => e.Name, new[] { name })[0];
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractActionTemplate))))
            {
                AbstractActionTemplate template = (AbstractActionTemplate) Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }
    }
}
