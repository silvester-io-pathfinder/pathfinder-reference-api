using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances
{
    public class ElvenGods : AbstractDeityCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("21e59657-5e46-4c14-87ac-a7349f030f19");

        protected override DeityCategory GetCategory()
        {
            return new DeityCategory 
            { 
                Id = ID,
                Name = "Elven Gods",
                Description = "The traditional deities of the elven pantheon are Calistria, Desna, Findeladlara (goddess of twilight and traditional art and architecture), Ketephys (god of hunting and the moon), and Yuelral (goddess of gems, craft, and magic). Elves have also adopted Alseta, a minor goddess of doors and transitions, as their patron of teleportation and aiudara (commonly known as elf gates). Most elves value magic, beauty, freedom, and friendship as part of a fulfilling life and tend to worship all of the deities together as exemplars of these values. Alongside fullblooded elves, many half-elves—whether raised by elves or seeking a closer connection to their elven heritage— worship the elven pantheon." 
            };
        }
    }
}
