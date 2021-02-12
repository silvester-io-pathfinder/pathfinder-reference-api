using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class StatSeeder : IEntitySeeder<Stat>
    {
        public IEnumerable<Stat> GetSeedEntities()
        {
            yield return new Stat { Id = Guid.Parse("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), Name = "Strength", Abbreviation = "STR" };
            yield return new Stat { Id = Guid.Parse("21b2cca1-66cd-48d1-a91b-085521659548"), Name = "Dexterity", Abbreviation = "DEX" };
            yield return new Stat { Id = Guid.Parse("10e9f065-a160-47e5-97df-72df4ec5ea15"), Name = "Constitution", Abbreviation = "CON" };
            yield return new Stat { Id = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Intellect", Abbreviation = "INT" };
            yield return new Stat { Id = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a"), Name = "Wisdom", Abbreviation = "WIS" };
            yield return new Stat { Id = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa"), Name = "Charisma", Abbreviation = "CHA" };
        }
    }
}
