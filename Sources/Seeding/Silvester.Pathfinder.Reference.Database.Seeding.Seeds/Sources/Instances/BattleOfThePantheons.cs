using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances
{
    public class BattleOfThePantheons : Template
    {
        public static readonly Guid ID = Guid.Parse("22bc45ce-7d4b-410d-8247-7c4c56882f79");

        protected override Source GetSource()
        {
            return new Source
            {
                Id = ID,
                Name = "Battle of the Pantheon"
            };
        }
    }
}
