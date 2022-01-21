using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class BreakthroughInnovation : Template
    {
        public static readonly Guid ID = Guid.Parse("5fc7b425-16fe-4abd-91f7-8ce81bc281c5");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 7,
                Name = "Breakthrough Innovation", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2a1fdee3-4fd5-4bd7-9ada-f2a3ded3dae5"), Type = TextBlockType.Text, Text = "You've made a breakthrough in your field of study and discovered a powerful new way to enhance your innovation. Choose a breakthrough modification of your innovation's type to apply to your innovation. You can choose an initial modification of your innovation's type instead if you prefer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyInnovationModification(Guid.Parse("7376ebce-2f3c-4c33-a325-d817cdb78922"), InnovationModificationTypes.Instances.Breakthrough.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c16fde1-a9e3-4d83-8ebd-2b24d9652442"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
