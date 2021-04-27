using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Races.Instances
{
    public class Catfolk : AbstractRaceTemplate
    {
        public static readonly Guid ID = Guid.Parse("14f3ef0d-aba9-4bed-8419-e9ffb1594cf5");

        protected override Race GetRace()
        {
            return new Race 
            {
                Id = ID, 
                BaseSpeed = 25, 
                Name = "Catfolk", 
                BaseHealth = 8, 
                RarityId = Rarities.Instances.Common.ID, 
                SizeId = RaceSizes.Instances.Medium.ID, 
                Description = "Curious and gregarious wanderers, catfolk combine features of felines and humanoids in both appearance and temperament. They enjoy learning new things, collecting new tales and trinkets, and ensuring their loved ones are safe and happy. Catfolk view themselves as chosen guardians of natural places in the world and are often recklessly brave, even in the face of overwhelming opposition." 
            };
        }

        protected override IEnumerable<Guid> GetLanguages()
        {
            yield return Languages.Instances.Common.ID;
            yield return Languages.Instances.Amurran.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Humanoid.ID;
            yield return Traits.Instances.Catfolk.ID;
        }
    }
}
