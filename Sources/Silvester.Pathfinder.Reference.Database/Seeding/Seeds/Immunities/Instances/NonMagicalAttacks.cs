using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Immunities.Instances
{
    public class NonMagicalAttacks : Template
    {
        public static readonly Guid ID = Guid.Parse("429b5ae3-b904-4903-8573-ca0f9694ee41");

        protected override Immunity GetHazardImmunity()
        {
            return new Immunity 
            {
                Id = ID, 
                Name = "Non-Magical Attacks"
            };
        }
    }
}
