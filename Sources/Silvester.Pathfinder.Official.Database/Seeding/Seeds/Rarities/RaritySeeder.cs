using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceRarities
{
    public class RaritySeeder
    {
        public ModelBuilder Builder { get; }

        public RaritySeeder(ModelBuilder builder)
        {
            Builder = builder;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractRarityTemplate))))
            {
                AbstractRarityTemplate template = (AbstractRarityTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }
    }
}
