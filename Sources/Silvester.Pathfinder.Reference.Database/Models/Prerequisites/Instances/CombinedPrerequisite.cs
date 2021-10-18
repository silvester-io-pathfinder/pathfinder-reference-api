using Silvester.Pathfinder.Reference.Database.Models.Effects;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class CombinedPrerequisite : Prerequisite
    {
        public ICollection<Prerequisite> Entries { get; set; } = new List<Prerequisite>();
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static EffectBuilder.Prerequisites AddCombination(this EffectBuilder.Prerequisites builder, Guid id, Guid bindingId, Action<List<Prerequisite>> configureAction)
        {
            List<Prerequisite> entries = new List<Prerequisite>();
            configureAction(entries);

            return builder.Add(bindingId, new CombinedPrerequisite { Id = id, Entries = entries});
        }
    }
}
