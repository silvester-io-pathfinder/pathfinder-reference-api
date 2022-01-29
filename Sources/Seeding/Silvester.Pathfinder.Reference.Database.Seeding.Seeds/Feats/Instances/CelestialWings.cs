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
    public class CelestialWings : Template
    {
        public static readonly Guid ID = Guid.Parse("e03f7933-e257-437a-b5f9-1f891fa1b87e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Celestial Wings",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa6f8142-df56-4fa1-a251-12cf52d79aa7"), Type = TextBlockType.Text, Text = $"With effort, you can call forth magical wings from your back, similar in appearance to those of your celestial forebears. These wings remain for 10 minutes. You gain a fly Speed equal to your Speed while you've manifested your wings." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c9ec452e-1f8b-4034-9f37-cc09a157a6be"), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse("c8ca8f56-e787-47f0-9b2d-e52df07f1f56"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("d57e083d-8b6e-4eb6-b0d4-58cd541f7475"), Traits.Instances.Morph.ID);
            builder.Add(Guid.Parse("6a11dd1d-6fb5-411e-a667-721b080018e8"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("343af2ad-7599-4ac7-aee1-2ea997b7ba3d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
