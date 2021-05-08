﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class WeaponCategory : BaseEntity
    {
        public string Name { get; set; } = default!;

        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}