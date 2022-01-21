using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances
{
    public class ManualPrerequisite : BasePrerequisite
    {
        public string Text { get; set; } = default!;
    }

    public static partial class EffectBuilderPrerequisitesExtensions
    {
        public static PrerequisiteBuilder Manual(this BooleanPrerequisiteBuilder builder, Guid id, string text)
        {
            return builder.Add(new ManualPrerequisite { Id = id, Text = text });
        }
    }
}
