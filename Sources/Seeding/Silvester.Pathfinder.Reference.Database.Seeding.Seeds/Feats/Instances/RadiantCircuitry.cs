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
    public class RadiantCircuitry : Template
    {
        public static readonly Guid ID = Guid.Parse("b53acb5e-ae39-4eab-ae77-e4f9d167f1cb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Radiant Circuitry",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3678dd27-a789-4b1c-ad10-3be84074ac1d"), Type = TextBlockType.Text, Text = $"Your biological circuitry emits light like a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("torch", Items.AdventuringGears.Instances.Torch.ID)}, casting bright light in a 20-foot radius (and dim light for the next 20 feet). The light shuts off when you take this action again or are knocked unconscious." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Android.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Light.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82519fc4-8f2c-43bd-bbc8-97394fb432ff"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
