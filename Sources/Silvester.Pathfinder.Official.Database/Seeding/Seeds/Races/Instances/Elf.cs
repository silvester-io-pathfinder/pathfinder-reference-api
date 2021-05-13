using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances
{
    public class Elf : Template
    {
        public static readonly Guid ID = Guid.Parse("e6ac68fc-98bf-4012-97a1-9910f988a1a4");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 30, 
                Name = "Elf", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = RaceSizes.Instances.Medium.ID, 
                Description = "As an ancient people, elves have seen great change and have the perspective that can come only from watching the arc of history. After leaving the world in ancient times, they returned to a changed land, and they still struggle to reclaim their ancestral homes, most notably from terrible demons that have invaded parts of their lands. To some, the elves are objects of awe—graceful and beautiful, with immense talent and knowledge. Among themselves, however, the elves place far more importance on personal freedom than on living up to these ideals." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Elven.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Elf.ID;
        }
    }
}
