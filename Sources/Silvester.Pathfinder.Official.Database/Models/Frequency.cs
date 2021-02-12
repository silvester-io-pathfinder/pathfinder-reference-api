using Silvester.Pathfinder.Official.Database;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Frequency : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Amount { get; set; } 

        public TimeSpan TimeSpan { get; set; }
    }
}
