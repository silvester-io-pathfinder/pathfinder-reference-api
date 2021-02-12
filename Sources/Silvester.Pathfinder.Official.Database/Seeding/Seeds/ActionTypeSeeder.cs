using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class ActionTypeSeeder : IEntitySeeder<ActionType>
    {
        public IEnumerable<ActionType> GetSeedEntities()
        {
            yield return new ActionType { Id = Guid.Parse("26ab8b82-ea91-4247-934b-618c724aca8b"), Name = "No Action" };
            yield return new ActionType { Id = Guid.Parse("4716abe4-50c3-447d-bb27-2b268667b3c2"), Name = "Free" };
            yield return new ActionType { Id = Guid.Parse("668ed964-cf7f-43df-b4b3-6a89c28551aa"), Name = "Reaction" };
            yield return new ActionType { Id = Guid.Parse("8a30c5b9-9024-4251-b0d4-147fefad1f2c"), Name = "One Action" };
            yield return new ActionType { Id = Guid.Parse("fe122850-b449-482d-8350-ac21e8985594"), Name = "Two Actions" };
            yield return new ActionType { Id = Guid.Parse("3fa12bb8-7b63-4c36-8e6e-d3cdd81580b8"), Name = "Three Actions" };
            yield return new ActionType { Id = Guid.Parse("11d73724-984e-4258-9157-6d0373363faa"), Name = "One or Two Actions" };
            yield return new ActionType { Id = Guid.Parse("80db0630-824c-4664-8ed8-460979a18404"), Name = "Two or Three Actions" };
        }
    }
}
