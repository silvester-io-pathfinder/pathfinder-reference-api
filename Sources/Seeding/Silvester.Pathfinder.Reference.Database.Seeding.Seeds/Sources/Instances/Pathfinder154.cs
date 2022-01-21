using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder154 : Template
    {
        public static readonly Guid ID = Guid.Parse("f8fc932f-25d6-4879-9878-bfa904b85454");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #154: Siege of the Dinosaurs"
            };
        }
    }
}
