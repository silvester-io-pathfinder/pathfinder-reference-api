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
    public class ExtinguishLight : Template
    {
        public static readonly Guid ID = Guid.Parse("b2f080d1-820d-46c6-b75f-8f4051560d50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Extinguish Light",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once every 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f130d9da-3db1-421d-878e-0b9317f57180"), Type = TextBlockType.Text, Text = $"You wrap shadow around a single unattended light source within 120 feet that's no larger than a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("torch", Items.AdventuringGears.Instances.Torch.ID)}. Any non-magical light source you target is automatically extinguished. For magical light sources, attempt a counteract check using your Fortitude or Thievery modifier against the target's DC. Your counteract level is equal to half your level rounded up. Successfully counteracting the light source suppresses its ability to produce light for 1 minute, but not any other effects. If you're in dim light or darkness when you Extinguish Light, its range is 240 feet." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("0e6dd9d5-d834-4419-861c-ea405faf57e6"), Traits.Instances.Darkness.ID);
            builder.Add(Guid.Parse("c621b6f1-b51c-4a89-af73-c647721ba507"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("66d3c9ef-4ff6-4ae6-a05e-16ef74b65240"), Traits.Instances.Fetchling.ID);
            builder.Add(Guid.Parse("51123cf2-f80d-4341-83ce-2ff8749ea2ff"), Traits.Instances.Occult.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("602158ec-25a8-4669-a328-be4384003f55"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
