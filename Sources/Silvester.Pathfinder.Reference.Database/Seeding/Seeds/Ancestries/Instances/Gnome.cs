using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances
{
    public class Gnome : Template
    {
        public static readonly Guid ID = Guid.Parse("3404bf2c-eb1c-4cc6-b376-450a969af548");

        protected override Ancestry GetAncestry()
        {
            return new Ancestry 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Gnome", 
                BaseHealth = 6, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = AncestrySizes.Instances.Small.ID, 
                Description = "Long ago, early gnome ancestors emigrated from the First World, realm of the fey. While it’s unclear why the first gnomes wandered to Golarion, this lineage manifests in modern gnomes as bizarre reasoning, eccentricity, obsessive tendencies, and what some see as naivete. These qualities are further reflected in their physical characteristics, such as spindly limbs, brightly colored hair, and childlike and extremely expressive facial features that further reflect their otherworldly origins." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Gnomish.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Gnome.ID;
        }
    }
}
