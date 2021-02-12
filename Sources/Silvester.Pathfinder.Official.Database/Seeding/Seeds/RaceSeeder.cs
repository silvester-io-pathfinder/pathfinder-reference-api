using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class RaceSeeder : IEntitySeeder<Race>
    {
        public IEnumerable<Race> GetSeedEntities()
        {
            yield return new Race { Id = Guid.Parse("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5"), BaseSpeed = 25, Name = "Catfolk", BaseHealth = 8, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") };
            yield return new Race { Id = Guid.Parse("a6f1c39a-feb8-4f62-95ce-1b5ffabbbbbf"), BaseSpeed = 25, Name = "Kobold", BaseHealth = 6, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2") };
            yield return new Race { Id = Guid.Parse("903f97e5-6972-4ad2-9377-447b7d6758a3"), BaseSpeed = 25, Name = "Orc", BaseHealth = 10, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") };
            yield return new Race { Id = Guid.Parse("a8430e0c-d52e-477c-a058-bc970a2113ea"), BaseSpeed = 25, Name = "Ratfolk", BaseHealth = 6, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2") };
            yield return new Race { Id = Guid.Parse("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce"), BaseSpeed = 25, Name = "Tengu", BaseHealth = 6, RarityId = Guid.Parse("5bf3f422-ef4f-4b99-a129-4875ffdfcbd0"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") };
        
            yield return new Race { Id = Guid.Parse("96a536c5-7fe0-4a25-af8b-881a2892b576"), BaseSpeed = 20, Name = "Dwarf", BaseHealth = 10, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") };
            yield return new Race { Id = Guid.Parse("e6ac68fc-98bf-4012-97a1-9910f988a1a4"), BaseSpeed = 30, Name = "Elf", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") };
            yield return new Race { Id = Guid.Parse("3404bf2c-eb1c-4cc6-b376-450a969af548"), BaseSpeed = 25, Name = "Gnome", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2") };
            yield return new Race { Id = Guid.Parse("519063b5-7283-4c0b-bb3a-d5d5edeba551"), BaseSpeed = 25, Name = "Goblin", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2") };
            yield return new Race { Id = Guid.Parse("ed816fd4-9e13-43b4-b80f-30d2b5c910ff"), BaseSpeed = 25, Name = "Halfling", BaseHealth = 6, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("0a06e806-0314-455c-8af8-c81ecc1e0dd2") };
            yield return new Race { Id = Guid.Parse("7fc53559-4776-482c-910c-be3bd84d2de4"), BaseSpeed = 25, Name = "Human", BaseHealth = 8, RarityId = Guid.Parse("52091c82-7a39-4a66-919e-ac268375b792"), SizeId = Guid.Parse("b2fb5eb7-73ac-4aad-9e20-ceb0487c1991") };
        }
    }

    public class RaceTraitJoiner : IEntityJoiner<Race, RaceTrait>
    {
        public RaceTrait[] Join(Race race, RaceTrait[] raceTraits)
        {
            return race.Name switch
            {
                "Catfolk" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Catfolk").ToArray(),
                "Kobold" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Kobold").ToArray(),
                "Orc" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Orc").ToArray(),
                "Ratfolk" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Ratfolk").ToArray(),
                "Tengu" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Tengu").ToArray(),
                "Dwarf" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Dwarf").ToArray(),
                "Elf" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Elf").ToArray(),
                "Gnome" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Gnome").ToArray(),
                "Goblin" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Goblin").ToArray(),
                "Halfling" => raceTraits.Where(e => e.Name == "Humanoid" || e.Name == "Halfling").ToArray(),
                "Human" => raceTraits.Where(e => e.Name == "Humanoid").ToArray(),
                _ => Array.Empty<RaceTrait>()
            };
        }
    }

    public class RaceLanguageJoiner : IEntityJoiner<Race, Language>
    {
        public Language[] Join(Race race, Language[] languages)
        {
            return race.Name switch
            {
                "Catfolk" => languages.Where(e => e.Name == "Common" || e.Name == "Amurrun").ToArray(),
                "Kobold" => languages.Where(e => e.Name == "Common" || e.Name == "Draconic").ToArray(),
                "Orc" => languages.Where(e => e.Name == "Common" || e.Name == "Orcish").ToArray(),
                "Ratfolk" => languages.Where(e => e.Name == "Common" || e.Name == "Ysoki").ToArray(),
                "Tengu" => languages.Where(e => e.Name == "Common" || e.Name == "Tengu").ToArray(),
                "Dwarf" => languages.Where(e => e.Name == "Common" || e.Name == "Dwarven").ToArray(),
                "Elf" => languages.Where(e => e.Name == "Common" || e.Name == "Elven").ToArray(),
                "Gnome" => languages.Where(e => e.Name == "Common" || e.Name == "Gnomish").ToArray(),
                "Goblin" => languages.Where(e => e.Name == "Common" || e.Name == "Goblin").ToArray(),
                "Halfling" => languages.Where(e => e.Name == "Common" || e.Name == "Halfling").ToArray(),
                "Human" => languages.Where(e => e.Name == "Common").ToArray(),
                _ => Array.Empty<Language>()
            };
        }
    }
}

