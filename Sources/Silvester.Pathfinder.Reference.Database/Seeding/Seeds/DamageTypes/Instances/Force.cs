using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Force : Template
    {
        public static readonly Guid ID = Guid.Parse("f9d8bf66-fe37-4c66-91f5-df5fb0a37f26");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID,
               Name = "Force"
               Description = "You resist Force damage."
           };
        }
    }
}
