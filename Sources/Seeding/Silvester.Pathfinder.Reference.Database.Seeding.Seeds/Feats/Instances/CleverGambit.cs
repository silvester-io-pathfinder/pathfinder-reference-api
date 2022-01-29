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
    public class CleverGambit : Template
    {
        public static readonly Guid ID = Guid.Parse("b8a0c303-b138-40b7-ac50-856a47cc74fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Gambit",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Strike critically hits and deals damage to a creature you've identified with Recall Knowledge.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e791a98e-a862-4b83-ad48-7e7140cf0804"), Type = TextBlockType.Text, Text = $"Your battle tactics are aided by your assessment of your foes' capabilities, allowing you to instantly adjust your movements to maximum advantage. You {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} or {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}; this movement doesn't trigger reactions from the triggering creature." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("603286cd-88cd-4b01-83fe-a4d3cd2d04fa"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
