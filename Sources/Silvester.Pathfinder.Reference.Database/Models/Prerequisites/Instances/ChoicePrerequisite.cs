using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class ChoicePrerequisite : Prerequisite
    {
        public ICollection<Prerequisite> Choices { get; set; } = new List<Prerequisite>();
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites AddChoice(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Action<List<Prerequisite>> configureAction)
        {
            List<Prerequisite> choices = new List<Prerequisite>();
            configureAction(choices);

            return builder.Add(bindingId, new ChoicePrerequisite { Id = id, Choices = choices });
        }
    }
}
