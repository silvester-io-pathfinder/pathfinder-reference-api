using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DivineFontSeeder : IEntitySeed<DivineFont>
    {
        public IEnumerable<DivineFont> GetSeedEntities()
        {
            yield return new DivineFont { Id = Guid.Parse("90698ae0-eb7f-49f2-b485-d7a1f9baf653"), Name = "Heal", Description = "You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only heal spells (page 343) in these slots, and the number of slots is equal to 1 plus your Charisma modifier." };
            yield return new DivineFont { Id = Guid.Parse("f724073c-4395-4f57-91ff-21fca4f0a6be"), Name = "Harm", Description = "You gain additional spell slots each day at your highest level of cleric spell slots. You can prepare only harm spells (page 343) in these slots, and the number of slots is equal to 1 plus your Charisma modifier." };
        }
    }
}
