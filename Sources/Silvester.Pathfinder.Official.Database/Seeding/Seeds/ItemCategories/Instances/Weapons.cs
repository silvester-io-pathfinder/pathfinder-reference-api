﻿using Silvester.Pathfinder.Official.Database.Models;
using System;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ItemCategories.Instances
{
    public class Weapons : AbstractItemCategoryTemplate
    {
        public static readonly Guid ID = Guid.Parse("7c5752cf-64d2-4d3e-a4ba-604969266172");

        protected override ItemCategory GetItemCategory()
        {
            return new ItemCategory 
            {
                Id = ID, 
                PageNumber = 599, 
                Name = "Weapons", 
                Description = "The rules for basic magical weapons, weapons made from precious materials, and specific magic weapons." 
            };
        }
    }
}