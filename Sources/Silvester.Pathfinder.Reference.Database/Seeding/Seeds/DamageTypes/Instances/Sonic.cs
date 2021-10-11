using Silvester.Pathfinder.Reference.Database.Models;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DamageTypes.Instances
{
    public class Sonic : Template
    {
        public static readonly Guid ID = Guid.Parse("62077401-195c-4c2e-834a-df442cec00e0");

        protected override DamageType GetAction()
        {
           return new DamageType 
           {
               Id = ID,
               Name = "Sonic"
           };
        }
    }
}
