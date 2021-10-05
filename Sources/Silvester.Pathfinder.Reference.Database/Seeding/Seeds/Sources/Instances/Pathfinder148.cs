using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder148 : Template
    {
        public static readonly Guid ID = Guid.Parse("8d75e2ed-fc45-457b-aa51-53c42e02312a");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #148: Fires of the Haunted City"
            };
        }
    }
}
