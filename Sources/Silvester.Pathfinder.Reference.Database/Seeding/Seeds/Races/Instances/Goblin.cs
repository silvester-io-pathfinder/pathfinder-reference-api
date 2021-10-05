using Silvester.Pathfinder.Reference.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Races.Instances
{
    public class Goblin : Template
    {
        public static readonly Guid ID = Guid.Parse("519063b5-7283-4c0b-bb3a-d5d5edeba551");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Goblin", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = RaceSizes.Instances.Small.ID, 
                Description = "The convoluted histories other people cling to don’t interest goblins. These small folk live in the moment, and they prefer tall tales over factual records. The wars of a few decades ago might as well be from the ancient past. Misunderstood by other people, goblins are happy how they are. Goblin virtues are about being present, creative, and honest. They strive to lead fulfilled lives, rather than worrying about how their journeys will end. To tell stories, not nitpick the facts. To be small, but dream big." 
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
