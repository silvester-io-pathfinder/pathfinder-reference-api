using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class DeityCategorySeeder : IEntitySeeder<DeityCategory>
    {
        public IEnumerable<DeityCategory> GetSeedEntities()
        {
            yield return new DeityCategory { Id = Guid.Parse("ab7e9ca8-6361-4309-83c6-6e3b1e5064cc"), Name = "Gods of the Inner Sea" };
            yield return new DeityCategory { Id = Guid.Parse("d4f49f9c-0107-478c-9d21-c9c5214e76bb"), Name = "Other Gods" };
            yield return new DeityCategory { Id = Guid.Parse("064c64d0-17be-4237-89b0-f04cf6e0fbfe"), Name = "Ancient Osirian Gods" };
            yield return new DeityCategory { Id = Guid.Parse("dd52c19b-ce83-4e46-ae17-6560d42c8c1a"), Name = "Archdevils" };
            yield return new DeityCategory { Id = Guid.Parse("141f20fa-a6a8-4ac7-88b8-edb2badc5b90"), Name = "Demon Lords" };
            yield return new DeityCategory { Id = Guid.Parse("cfa57951-60a1-48eb-9ac7-ff5ac36c8b02"), Name = "Dwarven Gods" };
            yield return new DeityCategory { Id = Guid.Parse("e2cdeaf6-9ea1-464c-aa82-045d042da2b5"), Name = "Eldest" };
            yield return new DeityCategory { Id = Guid.Parse("88b9adbd-19a6-43ae-8086-01688c9c84b2"), Name = "Elemental Lords" };
            yield return new DeityCategory { Id = Guid.Parse("21e59657-5e46-4c14-87ac-a7349f030f19"), Name = "Elven Gods" };
            yield return new DeityCategory { Id = Guid.Parse("50493d06-f3a6-4247-abb8-58202aa07447"), Name = "Empyreal Lords" };
            yield return new DeityCategory { Id = Guid.Parse("4d699f44-5321-4d9b-ba78-026c638260e9"), Name = "Horsemen" };
            yield return new DeityCategory { Id = Guid.Parse("45bda584-ba71-45c5-a91d-a3e9e07ee0a3"), Name = "Monitor Demigods" };
            yield return new DeityCategory { Id = Guid.Parse("1a209857-903b-4a88-9c42-bfcaf5f7b053"), Name = "Old Sun Gods" };
            yield return new DeityCategory { Id = Guid.Parse("cb0c42c1-2f21-4c52-b419-09d55a7b8eca"), Name = "Outer Gods and Great Old Ones" };
            yield return new DeityCategory { Id = Guid.Parse("95ffee72-4042-47a8-8e82-3ff82c51d55c"), Name = "Pantheons" };
            yield return new DeityCategory { Id = Guid.Parse("cb6ebc9d-9a0e-4d7c-9a7d-d5da7ea043bd"), Name = "Queens of the Night" };
            yield return new DeityCategory { Id = Guid.Parse("aa2c5a37-9a30-4bdb-904e-ca1de189edbb"), Name = "Sarkorian Gods" };
            yield return new DeityCategory { Id = Guid.Parse("60738a86-c7af-4b79-b29c-a0e861a08da4"), Name = "Tian Gods" };
            yield return new DeityCategory { Id = Guid.Parse("9071aac4-ebdd-45a5-ba88-e4af3c56d111"), Name = "Vudrani Gods" };
        }
    }
}
