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
    public class ElementalEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("67050ebf-4dfc-405f-b004-11acb9424bcd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Eyes",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can select this feat only at 1st level, and you can't retrain into or out of this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3185e95-7368-4ec4-adfe-76bbb523dbda"), Type = TextBlockType.Text, Text = $"You can see in the darkness as easily as an elemental. You gain darkvision." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("da8b4962-2631-400c-906a-870ccdcf154b"), Senses.Instances.LowLightVision.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ad562d43-1e93-42b5-8ca7-e94e0014ea71"), Traits.Instances.Ifrit.ID);
            builder.Add(Guid.Parse("14bd297b-95ed-49d3-8974-bb3e8a13bcc7"), Traits.Instances.Oread.ID);
            builder.Add(Guid.Parse("a5c7ab8c-9620-4188-b6cd-8c058e5b2101"), Traits.Instances.Suli.ID);
            builder.Add(Guid.Parse("c5cec857-29be-486f-a7bb-f3c0560187f1"), Traits.Instances.Sylph.ID);
            builder.Add(Guid.Parse("609985ec-df97-437f-8057-2cdf1c785dd0"), Traits.Instances.Undine.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8a8a32c-6e73-407e-8593-2924c6634761"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
