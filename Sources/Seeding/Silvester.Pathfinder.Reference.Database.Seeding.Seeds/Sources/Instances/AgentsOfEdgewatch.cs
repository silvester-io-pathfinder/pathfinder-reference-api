using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class AgentsOfEdgewatch : Template
    {
        public static readonly Guid ID = Guid.Parse("b3624671-a395-4b66-96ea-0be11fb5152e");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Agents of Edgewatch"
            };
        }
    }
}
