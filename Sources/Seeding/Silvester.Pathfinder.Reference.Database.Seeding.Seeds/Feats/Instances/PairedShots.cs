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
    public class PairedShots : Template
    {
        public static readonly Guid ID = Guid.Parse("902c04b7-5913-4e44-8fb2-d4deddb5a834");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Paired Shots",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5f6704cf-b874-4582-8f98-1bd2c9a3fbfc"), Type = TextBlockType.Text, Text = $"Your shots hit simultaneously. Make two {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, one with each of your two ranged weapons, each using your current multiple attack penalty. Both {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} must have the same target." };
            yield return new TextBlock { Id = Guid.Parse("d51455d3-5603-4ba7-afc6-bb9d9477ac92"), Type = TextBlockType.Text, Text = $"If both attacks hit, combine their damage and then add any applicable effects from both weapons. You add any precision damage, only once, to the attack of your choice. Combine the damage from both {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} and apply resistances and weaknesses only once. This counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8e8a6aa7-707b-45ba-8cc7-0c67a62a12a2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
