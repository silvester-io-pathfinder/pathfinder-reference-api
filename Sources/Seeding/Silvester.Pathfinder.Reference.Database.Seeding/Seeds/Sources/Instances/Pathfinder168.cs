using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Pathfinder168 : Template
    {
        public static readonly Guid ID = Guid.Parse("81a46564-9733-4d49-983f-543e08763c59");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Pathfinder #168: King of the Mountain"
            };
        }
    }
}
