using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder157 : Template
    {
        public static readonly Guid ID = Guid.Parse("9812077c-2f7a-4657-9312-1f44f9a95e3a");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #157: Devil at the Dreaming Palace"
            };
        }
    }
}
