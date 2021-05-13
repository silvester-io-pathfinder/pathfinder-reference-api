using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances
{
    public class TrueNeutral : Template
    {
        public static readonly Guid ID = Guid.Parse("094aecb0-6e14-433f-afa5-eb7d0f3ab64a");

        protected override Alignment GetAlignment()
        {
           return new Alignment 
           { 
               Id = ID, 
               Name = "True Neutral", 
               Description = "A true neutral character is neutral on both axes and tends not to feel strongly towards any alignment, or actively seeks their balance." 
           };
        }
    }
}
