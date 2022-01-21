using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class AbominationVaults : Template
    {
        public static readonly Guid ID = Guid.Parse("32e6d72d-01c0-4960-aa29-b8b1487ce75b");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Abomination Vaults"
            };
        }
    }
}
