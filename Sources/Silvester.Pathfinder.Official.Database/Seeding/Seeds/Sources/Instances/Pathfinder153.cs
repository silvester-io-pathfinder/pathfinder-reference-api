using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder153 : Template
    {
        public static readonly Guid ID = Guid.Parse("2a277f0c-a448-4de7-8308-5c7f7acc9ced");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #153: Life's Long Shadow"
            };
        }
    }
}
