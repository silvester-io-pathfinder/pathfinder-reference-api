using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances
{
    public class Halfling : Template
    {
        public static readonly Guid ID = Guid.Parse("ed816fd4-9e13-43b4-b80f-30d2b5c910ff");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Halfling", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = RaceSizes.Instances.Small.ID, 
                Description = "Claiming no place as their own, halflings control few settlements larger than villages. Instead, they frequently live among humans within the walls of larger cities, carving out small communities alongside taller folk. Many halflings lead perfectly fulfilling lives in the shadows of their larger neighbors, while others prefer a nomadic existence, traveling the world and taking advantage of opportunities and adventures as they come." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Goblin.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Goblin.ID;
        }
    }
}
