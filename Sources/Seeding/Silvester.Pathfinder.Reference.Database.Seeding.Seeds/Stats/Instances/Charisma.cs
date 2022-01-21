using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances
{
    public class Charisma : Template
    {
        public static readonly Guid ID = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa");

        protected override Stat GetStat()
        {
            return new Stat 
            {
                Id = ID,
                Name = "Charisma", 
                Abbreviation = "CHA",
                Description = "Charisma measures your character's personal magnetism and strength of personality. A high Charisma score helps you influence the thoughts and moods of others." 
            };
        }
    }
}
