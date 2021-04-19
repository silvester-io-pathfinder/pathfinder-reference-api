using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class StatSeeder : IEntitySeed<Stat>
    {
        public IEnumerable<Stat> GetSeedEntities()
        {
            yield return new Stat { Id = Guid.Parse("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137"), Name = "Strength", Abbreviation = "STR", Description = "Strength measures your character’s physical power.  Strength is important if your character plans to engage in hand - to - hand combat.Your Strength modifier gets added to melee damage rolls and determines how much your character can carry."};
            yield return new Stat { Id = Guid.Parse("21b2cca1-66cd-48d1-a91b-085521659548"), Name = "Dexterity", Abbreviation = "DEX", Description = "Dexterity measures your character’s agility, balance, and reflexes. Dexterity is important if your character plans to make attacks with ranged weapons or use stealth to surprise foes. Your Dexterity modifier is also added to your character’s AC and Reflex saving throws." };
            yield return new Stat { Id = Guid.Parse("10e9f065-a160-47e5-97df-72df4ec5ea15"), Name = "Constitution", Abbreviation = "CON", Description = "Constitution measures your character’s overall health and stamina. Constitution is an important statistic for all characters, especially those who fight in close combat.  Your Constitution modifier is added to your Hit Points and Fortitude saving throws." };
            yield return new Stat { Id = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd"), Name = "Intellect", Abbreviation = "INT", Description = "Intelligence measures how well your character can learn and reason. A high Intelligence allows your character to analyze situations and understand patterns, and it means they can become trained in additional skills and might be able to master additional languages." };
            yield return new Stat { Id = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a"), Name = "Wisdom", Abbreviation = "WIS", Description = "Wisdom measures your character’s common sense, awareness, and intuition. Your Wisdom modifier is added to your Perception and Will saving throws." };
            yield return new Stat { Id = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa"), Name = "Charisma", Abbreviation = "CHA", Description = "Charisma measures your character’s personal magnetism and strength of personality. A high Charisma score helps you influence the thoughts and moods of others." };
        }
    }
}
