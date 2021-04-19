using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources
{
    public class SourceSeeder
    {
        public ModelBuilder Builder { get; }

        public SourceSeeder(ModelBuilder builder)
        {
            Builder = builder;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractSourceTemplate))))
            {
                AbstractSourceTemplate template = (AbstractSourceTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }
    }
}
