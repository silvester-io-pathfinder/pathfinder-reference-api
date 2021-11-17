using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Frequency : BaseEntity
    {
        public string Name { get; set; } = default!;

        public int Amount { get; set; } 

        public TimeSpan TimeSpan { get; set; }
    }
}
