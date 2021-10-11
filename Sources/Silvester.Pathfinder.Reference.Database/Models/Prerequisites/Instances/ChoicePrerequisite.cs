using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class ChoicePrerequisite : Prerequisite
    {
        public ICollection<Prerequisite> Choices { get; set; } = new List<Prerequisite>();
    }
}
