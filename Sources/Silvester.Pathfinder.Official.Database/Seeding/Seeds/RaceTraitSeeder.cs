using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class RaceTraitSeeder : IEntitySeeder<RaceTrait>
    {
        public IEnumerable<RaceTrait> GetSeedEntities()
        {
            yield return new RaceTrait { Id = Guid.Parse("54611353-c19f-452b-91c3-557a80a661c4"), Name = "Humanoid" };
            yield return new RaceTrait { Id = Guid.Parse("21de256c-7e2c-401c-bc8e-d2ad49ac1473"), Name = "Elf" };
            yield return new RaceTrait { Id = Guid.Parse("852a5dc2-9cc6-4fb0-9250-801e27b1f8a3"), Name = "Dwarf" };
            yield return new RaceTrait { Id = Guid.Parse("5138d6c9-4abf-446c-9e1b-5660a956242a"), Name = "Gnome" };
            yield return new RaceTrait { Id = Guid.Parse("d15ee066-6c0e-4068-825e-79a87e3fecd6"), Name = "Goblin" };
            yield return new RaceTrait { Id = Guid.Parse("6857833c-2458-4ece-b784-69b45a8afa63"), Name = "Halfling" };
            yield return new RaceTrait { Id = Guid.Parse("aab5afb3-53d2-4b4f-a070-bf6e697844f3"), Name = "Human" };
            yield return new RaceTrait { Id = Guid.Parse("ca44727c-ddd1-45b3-bb03-2e0cf7c10dc6"), Name = "Catfolk" };
            yield return new RaceTrait { Id = Guid.Parse("e6ec055e-2598-48c4-b003-2b07f8847a41"), Name = "Kobold" };
            yield return new RaceTrait { Id = Guid.Parse("06fa7847-6549-48a9-81cf-54be921e98bb"), Name = "Orc" };
            yield return new RaceTrait { Id = Guid.Parse("2ee1182b-590e-4ba0-b25a-404ebdfa365d"), Name = "Ratfolk" };
            yield return new RaceTrait { Id = Guid.Parse("4f75a119-344a-488a-b905-ed558e450f33"), Name = "Tengu" };
        }
    }
}
