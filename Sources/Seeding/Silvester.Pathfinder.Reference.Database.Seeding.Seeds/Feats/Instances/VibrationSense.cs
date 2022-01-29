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
    public class VibrationSense : Template
    {
        public static readonly Guid ID = Guid.Parse("0e33c5dd-fc9d-47d3-bc2e-71853ead7ab0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vibration Sense",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0fa7f8e9-a46f-461e-8a3b-48f69d75dff8"), Type = TextBlockType.Text, Text = $"Your eidolon gains tremorsense as an imprecise sense with a range of 30 feet. If aquatic, it gains wavesense as an imprecise sense with a range of 30 feet instead. If amphibious, it gains both." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("243f2440-72b5-4f66-ab1f-b95ab10fc84b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
