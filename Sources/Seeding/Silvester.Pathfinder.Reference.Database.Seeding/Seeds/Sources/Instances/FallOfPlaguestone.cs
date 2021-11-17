using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class FallOfPlaguestone : Template
    {
        public static readonly Guid ID = Guid.Parse("6e4fcd52-b08b-492e-b7cf-91b686399a79");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Fall of Plaguestone"
            };
        }
    }
}
