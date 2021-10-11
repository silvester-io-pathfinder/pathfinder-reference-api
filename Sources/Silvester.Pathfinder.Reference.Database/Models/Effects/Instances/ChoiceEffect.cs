using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ChoiceEffect : Effect
    {
        public string? Restrictions { get; set; }

        public ICollection<Effect> Choices { get; set; } = new List<Effect>();

        public ChoiceEffect()
        {

        }
    }
}
