using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCurses
{
    public class ItemCurseSeeder
    {
        public ModelBuilder Builder { get; }

        private Source[] Sources { get; }

        private Trait[] Traits { get; }

        public ItemCurseSeeder(ModelBuilder builder, Source[] sources, Trait[] traits)
        {
            Builder = builder;
            Sources = sources;
            Traits = traits;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractItemCurseTemplate))))
            {
                AbstractItemCurseTemplate template = (AbstractItemCurseTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Traits.Filter(e => e.Name, traitNames);
        }

        public Source GetSourceByName(string name)
        {
            return Sources.Filter((e) => e.Name, name).First();
        }
    }
}
