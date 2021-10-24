using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class Bestiary2 : Template
    {
        public static readonly Guid ID = Guid.Parse("51f273bd-9c56-4a21-82ca-df90e1e13955");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Bestiary 2"
            };
        }
    }
}
