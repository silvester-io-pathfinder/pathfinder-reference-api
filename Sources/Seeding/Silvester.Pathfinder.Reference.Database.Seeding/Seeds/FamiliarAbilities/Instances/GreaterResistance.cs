using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class GreaterResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("82765bc9-2e1d-498c-b826-97351a4a0761");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Greater Resistance", 
                Description = "Your familiar increases the resistance it gains from its resistance familiar ability to 3 + half your level. Your familiar must have the resistance ability to select this."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec495f8e-432c-4d3b-9f73-35333e4b37ed"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
