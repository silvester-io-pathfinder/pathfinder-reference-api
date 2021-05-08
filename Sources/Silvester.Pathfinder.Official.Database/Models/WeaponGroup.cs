﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class WeaponGroup : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string CriticalEffect { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Weapon> Weapons { get; set; } = new List<Weapon>();
    }
}