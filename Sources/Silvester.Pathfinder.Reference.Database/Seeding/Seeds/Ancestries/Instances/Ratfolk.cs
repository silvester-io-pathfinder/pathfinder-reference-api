using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Ratfolk : Template
    {
        public static readonly Guid ID = Guid.Parse("a8430e0c-d52e-477c-a058-bc970a2113ea");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Ratfolk", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                SizeId = AncestrySizes.Instances.Small.ID, 
                Description = "Ysoki—as ratfolk call themselves—are a clever, adaptable, and fastidious ancestry who happily crowd their large families into the smallest of living spaces." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Ysoki.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Ratfolk.ID;
        }
    }
}
