using Silvester.Pathfinder.Official.Database;
using System;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class RollableEffect : BaseEntity
    {
        public string? CriticalSuccess { get; set; }

        public string? Success { get; set; } 

        public string? Failure { get; set; } 

        public string? CriticalFailure { get; set; }
    }
}
