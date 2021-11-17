using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class MajorResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("d2f4ef3b-4e83-4e91-a8c2-fa5b1fce27c7");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Major Resistance", 
                Description = "Your familiar increases the resistance it gains from its resistance familiar ability to a value equal to your level. To select this, your familiar must have the greater resistance ability and you must be at least 8th level."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db061bbd-ab1b-482a-969a-b2b28ab538c5"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
