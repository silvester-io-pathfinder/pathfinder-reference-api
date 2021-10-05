using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances
{
    public class Strength : Template
    {
        public static readonly Guid ID = Guid.Parse("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137");

        protected override Stat GetStat()
        {
            return new Stat 
            {
                Id = ID, 
                Name = "Strength", 
                Abbreviation = "STR", 
                Description = "Strength measures your character’s physical power.  Strength is important if your character plans to engage in hand - to - hand combat.Your Strength modifier gets added to melee damage rolls and determines how much your character can carry." 
            };
        }
    }
}
