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
    public class WindingFlow : Template
    {
        public static readonly Guid ID = Guid.Parse("53c5d6a3-68d8-46bc-8550-751de6991e78");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Winding Flow",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72e2e033-3564-4675-805c-91a6f62a500f"), Type = TextBlockType.Text, Text = $"Any journey consists of more than simply reaching your destination. You use two of the following actions in any order: {ToMarkdownLink<Models.Entities.Action>("Stand", Actions.Instances.Stand.ID)}, {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, and {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}. You can't use the same action twice." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Monk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e126728d-eda1-44d1-af5f-ad1de682098e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
