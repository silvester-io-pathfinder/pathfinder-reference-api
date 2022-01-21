using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class CoreRulebook : Template
    {
        public static readonly Guid ID = Guid.Parse("4e85ec44-4a72-4bea-a3e5-5e6d88882d75");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Core Rulebook"
            };
        }
    }
}
