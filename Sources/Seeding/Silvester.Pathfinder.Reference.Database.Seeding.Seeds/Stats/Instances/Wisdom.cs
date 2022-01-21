using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Stats.Instances
{
    public class Wisdom : Template
    {
        public static readonly Guid ID = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a");

        protected override Stat GetStat()
        {
            return new Stat
            {
                Id = ID,
                Name = "Wisdom", 
                Abbreviation = "WIS",
                Description = "Wisdom measures your character's common sense, awareness, and intuition. Your Wisdom modifier is added to your Perception and Will saving throws." 
            };
        }
    }
}
