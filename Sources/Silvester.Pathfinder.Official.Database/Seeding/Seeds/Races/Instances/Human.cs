using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances
{
    public class Human : AbstractRaceTemplate
    {
        public static readonly Guid ID = Guid.Parse("7fc53559-4776-482c-910c-be3bd84d2de4");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Human", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = RaceSizes.Instances.Medium.ID, 
                Description = "As unpredictable and varied as any of Golarion’s peoples, humans have exceptional drive and the capacity to endure and expand. Though many civilizations thrived before humanity rose to prominence, humans have built some of the greatest and the most terrible societies throughout the course of history, and today they are the most populous people in the realms around the Inner Sea." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
        }
    }
}
