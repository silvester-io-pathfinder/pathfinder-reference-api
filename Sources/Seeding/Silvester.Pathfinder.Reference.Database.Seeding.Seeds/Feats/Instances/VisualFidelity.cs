using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VisualFidelity : Template
    {
        public static readonly Guid ID = Guid.Parse("dd3c3cf8-209f-49ef-9515-8043a65269be");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Visual Fidelity",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2035392f-3124-4d3e-bb6e-be90e0c74f3f"), Type = TextBlockType.Text, Text = $"You've found a way to use a hodgepodge combination of devices to enhance your visual abilities in every situation. You gain darkvision and low-light vision, and you can see invisible creatures and objects as translucent shapes, though these shapes are indistinct enough to be concealed to you." };
            yield return new TextBlock { Id = Guid.Parse("88ac657c-b946-451e-9e82-faf6b5def6f2"), Type = TextBlockType.Text, Text = $"If an effect would give you the blinded condition, the effect must attempt a counteract check against your class DC, with your counteract level equaling half your level, rounded up. On a failed counteract check, you aren't blinded—your various devices are able to compensate." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("893c4254-68b7-4b60-96f3-6d84c62971ce"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
