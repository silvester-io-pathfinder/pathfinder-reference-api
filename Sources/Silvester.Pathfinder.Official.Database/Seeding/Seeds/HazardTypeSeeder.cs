using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class HazardTypeSeeder : IEntitySeed<HazardType>
    {
        public IEnumerable<HazardType> GetSeedEntities()
        {
            yield return new HazardType { Id = Guid.Parse("db68d894-7a5a-489f-a6f5-ca45ef6986f6"), SourcePageId = Guid.Parse("ffe77480-d1b7-4155-9152-4bbb4a651721"), Name = "Traps", Description = "Traps are usually built or placed, though they can also form accidentally, such as if a magic portal, through millennia of disuse, malfunctions as its magic warps. Mechanical traps always have some physical component, whereas purely magical traps typically don’t. Magical traps can usually be counteracted by dispel magic, and those without a listed proficiency rank for Stealth can be found using detect magic. Thievery is the most common skill used to disable traps." };
            yield return new HazardType { Id = Guid.Parse("6b56b0d2-5b30-4ccf-b72c-532c244d9b73"), SourcePageId = Guid.Parse("3ab73fe4-1b68-42e0-8a0e-c7cc58cb5301"), Name = "Environmental Hazards", Description = "Environmental hazards are either living things, like dangerous spores and molds, or simply features of the terrain or environment, like avalanches or rockslides. While they are always physical, some environmental hazards can’t reasonably be attacked or damaged, such as a cloud of poisonous gas or a patch of quicksand. Survival is the most common skill used to disable environmental hazards." };
            yield return new HazardType { Id = Guid.Parse("9d0426d4-021e-4822-a114-04840f3bb9c4"), SourcePageId = Guid.Parse("8419e536-0368-4dc8-ae2b-72d472a4d869"), Name = "Haunts", Description = "Haunts are spiritual hazards, usually formed when the spiritual essence of a location is imprinted with the instincts and emotions from a living being’s demise. Because haunts lack matter, they rarely involve a physical component, and when they do, that component is generally incorporeal or might even be damaged only by positive energy. The skills and options used to disable haunts vary, though using Religion for an exorcism is common. However, even with a successful check to disable a haunt, it can reoccur until its unfinished business is resolved. Typically, successfully disabling or enduring a haunt provides clues to determine what it would take to lay it to rest permanently." };
        }
    }

    public class HazardTypeSourcePageSeeder : IEntitySeed<SourcePage>
    {
        public IEnumerable<SourcePage> GetSeedEntities()
        {
            yield return new SourcePage { Id = Guid.Parse("ffe77480-d1b7-4155-9152-4bbb4a651721"), SourceId = Guid.Parse("643d5da8-e766-44c9-9748-7ad1ac97dcbf"), Page = 74};
            yield return new SourcePage { Id = Guid.Parse("3ab73fe4-1b68-42e0-8a0e-c7cc58cb5301"), SourceId = Guid.Parse("643d5da8-e766-44c9-9748-7ad1ac97dcbf"), Page = 74};
            yield return new SourcePage { Id = Guid.Parse("8419e536-0368-4dc8-ae2b-72d472a4d869"), SourceId = Guid.Parse("643d5da8-e766-44c9-9748-7ad1ac97dcbf"), Page = 74};
        }
    }
}
