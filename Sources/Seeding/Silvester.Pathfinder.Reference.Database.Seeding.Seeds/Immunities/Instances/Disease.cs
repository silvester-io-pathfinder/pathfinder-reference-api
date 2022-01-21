using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class Disease : Template
    {
        public static readonly Guid ID = Guid.Parse("802f5ff0-2ec5-4add-9ac0-ef3e63d90f17");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Disease"
            };
        }
    }
}
