﻿using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorCategories.Instances
{
    public class MediumArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("199f2e7d-5249-45ee-af4d-b3f7cdd257b8");

        protected override ArmorCategory GetArmorCategory()
        {
            return new ArmorCategory
            {
                Id = ID,
                Name = "Medium Armor"
            };
        }
    }
}
