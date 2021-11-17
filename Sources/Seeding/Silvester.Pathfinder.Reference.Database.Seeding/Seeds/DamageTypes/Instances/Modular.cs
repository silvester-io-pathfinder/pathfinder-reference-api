using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Modular : Template
    {
        public static readonly Guid ID = Guid.Parse("3f2fe0bc-7952-4593-b9a6-d24b8aede62d");

        protected override DamageType GetAction()
        {
           return new DamageType 
           { 
               Id = ID, 
               Name = "Modular",
               Description = "You resist Modular damage."
           };
        }
    }
}
