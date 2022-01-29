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
    public class LightPaws : Template
    {
        public static readonly Guid ID = Guid.Parse("1b08ede0-d310-4a2c-9c6b-439a1696444e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Light Paws",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95ef6cdb-b4e6-4fd7-8e6c-6c78b92f95a3"), Type = TextBlockType.Text, Text = $"You can balance on your toes to step carefully over obstructions. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} and then {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)}, or {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} and then {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, ignoring difficult terrain during this movement." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Catfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9e10222-456d-4423-aa37-939c4077fbf1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
