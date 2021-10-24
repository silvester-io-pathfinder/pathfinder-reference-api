using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class Paralysis : Template
    {
        public static readonly Guid ID = Guid.Parse("7a5d6b5a-c49e-4686-8104-e2d846670cef");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Paralysis"
            };
        }
    }
}
