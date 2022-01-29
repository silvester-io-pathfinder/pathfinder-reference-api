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
    public class PrimalFocus : Template
    {
        public static readonly Guid ID = Guid.Parse("2d401457-b791-4cfc-bb98-943a072b76c9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Primal Focus",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2019b1e5-4cfb-4fb9-8451-37e369eba7df"), Type = TextBlockType.Text, Text = $"Your connection to nature is particularly strong, and the spirits of nature flock around you, helping you replenish your focus. If you have spent at least 2 Focus Points since the last time you {ToMarkdownLink<Models.Entities.Activity>("Refocused", Activities.Instances.Refocus.ID)}, you recover 2 Focus Points when you {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} instead of 1." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("112df70d-5b90-49ec-aca5-7fae123268b4"), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0328019-9b68-437e-8632-20ab37da7ee8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
