using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Wavesense : Template
    {
        public static readonly Guid ID = Guid.Parse("66ae064e-cf74-429c-ad33-c5c2f8a64217");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Wavesense", 
                Description = "Your familiar can sense vibrations in the water. It gains imprecise wavesense with a range of 30 feet."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bccfe410-064c-4239-93c6-ae896ae42e25"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
