using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FamiliarAbilities.Instances
{
    public class Tremorsense : Template
    {
        public static readonly Guid ID = Guid.Parse("e8d36953-ec04-40b1-b17e-6994b6434efe");

        protected override FamiliarAbility GetFamiliarAbility()
        {
            return new FamiliarAbility
            {
                Id = ID, 
                Name = "Tremorsense", 
                Description = "Your familiar is keenly aware of any vibrations traveling through a surface. It gains imprecise tremorsense with a range of 30 feet."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5dd8841-6c9a-4b9a-bf97-35c02851d2c3"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
