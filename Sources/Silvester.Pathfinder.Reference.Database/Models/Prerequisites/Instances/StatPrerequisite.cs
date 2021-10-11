using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class StatPrerequisite : Prerequisite
    {
        public int RequiredStatValue { get; set; }

        public Guid RequiredStatId { get; set; }
        public Stat RequiredStat { get; set; } = default!;
    }
}
