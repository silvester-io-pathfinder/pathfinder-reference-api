using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class CombinedPrerequisite : Prerequisite
    {
        public ICollection<Prerequisite> Entries { get; set; } = new List<Prerequisite>();
    }
}
