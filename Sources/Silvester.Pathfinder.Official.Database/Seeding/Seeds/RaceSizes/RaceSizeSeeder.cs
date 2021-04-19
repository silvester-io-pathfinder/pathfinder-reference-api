using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes
{
    public class RaceSizeSeeder
    {
        public ModelBuilder Builder { get; }

        public RaceSizeSeeder(ModelBuilder builder)
        {
            Builder = builder;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractRaceSizeTemplate))))
            {
                AbstractRaceSizeTemplate template = (AbstractRaceSizeTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }
    }
}
