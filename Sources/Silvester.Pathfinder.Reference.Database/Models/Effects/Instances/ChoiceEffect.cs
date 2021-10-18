using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Effects.Instances
{
    public class ChoiceEffect : Effect
    {
        public string? Restrictions { get; set; }

        public ICollection<ChoiceEffectBinding> Choices { get; set; } = new List<ChoiceEffectBinding>();

        public ChoiceEffect()
        {

        }
    }
}
