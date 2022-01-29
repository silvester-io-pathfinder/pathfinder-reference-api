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
    public class RevolutionaryInnovation : Template
    {
        public static readonly Guid ID = Guid.Parse("1434c78b-94f3-470b-b234-7a766de7fb87");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Revolutionary Innovation", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bbe0fe56-d71e-4b28-9731-34899d303ea6"), Type = TextBlockType.Text, Text = "You are an unparalleled genius and have discovered a technique that will revolutionize your chosen field - or at least for the time being, your innovation! Choose a revolutionary modification to apply to your innovation. You can also choose an initial or breakthrough modification of the same type instead, if you prefer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyInnovationModification(Guid.Parse("5b0de6aa-9209-4837-b270-7b82d275e53e"), InnovationModificationTypes.Instances.Revolutionary.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a41399dd-4b76-4345-8f4f-d651ab1306a8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 23
            };
        }
    }
}
