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
    public class Grimspawn : Template
    {
        public static readonly Guid ID = Guid.Parse("a6ff088d-c6e4-4d79-b618-5bc5d3cb1fca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grimspawn",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("920c6391-6a82-4345-ba31-f68f9bab0930"), Type = TextBlockType.Text, Text = $"Your lineage traces back to a daemon, one of the manifestations of horrific forms of death that devour souls within their foul home of Abaddon. As a result, you cling tenaciously to the last shreds of your own life force. You gain the {ToMarkdownLink<Models.Entities.Feat>("Diehard", Feats.Instances.Diehard.ID)} feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Tiefling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7e8f95f-9eac-4cc4-9487-5d9f092ca4e9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
