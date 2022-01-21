using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ArmorCategories.Instances
{
    public class Unarmored : Template
    {
        public static readonly Guid ID = Guid.Parse("3e53fcd2-e07b-4af5-b331-b4372acacf74");

        protected override ArmorCategory GetArmorCategory()
        {
            return new ArmorCategory
            {
                Id = ID,
                Name = "Unarmored"
            };
        }
    }
}
