using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Positive : Template
    {
        public static readonly Guid ID = Guid.Parse("e9abd2b5-bddf-47b6-b507-07a67c3d73f6");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID,
               Name = "Positive"
               Description = "You resist Positive damage."
           };
        }
    }
}
