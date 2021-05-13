using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances
{
    public class Tengu : Template
    {
        public static readonly Guid ID = Guid.Parse("8fec37b8-ec4a-4094-90a0-4e70b12fd6ce");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Tengu", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SizeId = RaceSizes.Instances.Medium.ID, 
                Description = "Tengus are a gregarious and resourceful people that have spread far and wide from their ancestral home in Tian Xia, collecting and combining whatever innovations and traditions they happen across with those from their own long history." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Tengu.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Tengu.ID;
        }
    }
}
