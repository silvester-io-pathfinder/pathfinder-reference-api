using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class AgeOfAshes : Template
    {
        public static readonly Guid ID = Guid.Parse("21f5dbb7-3fff-4f21-bb3a-a94ba8a85700");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Age of Ashes"
            };
        }
    }
}
