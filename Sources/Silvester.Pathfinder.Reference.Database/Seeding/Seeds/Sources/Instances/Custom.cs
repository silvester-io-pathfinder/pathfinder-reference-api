using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Custom : Template
    {
        public static readonly Guid ID = Guid.Parse("f81a5e37-0ec8-443d-924b-75769a2d321b");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Custom"
            };
        }
    }
}
