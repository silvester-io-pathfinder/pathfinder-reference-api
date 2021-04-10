using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Conditions
{
    public class ConditionSeeder
    {
        public ModelBuilder Builder { get; }

        public Source[] Sources{ get; }

        public ConditionCategory[] ConditionCategories { get; }

        public ConditionSeeder(ModelBuilder builder, Source[] sources, ConditionCategory[] conditionCategories)
        {
            Builder = builder;
            Sources = sources;
            ConditionCategories = conditionCategories;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractConditionTemplate))))
            {
                AbstractConditionTemplate template = (AbstractConditionTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Source GetSourceByName(string name)
        {
            return Sources.Filter((e) => e.Name, name).First();
        }

        public ConditionCategory GetCategoryByName(string name)
        {
            return ConditionCategories.Filter((e) => e.Name, name).First();
        }
    }
}
