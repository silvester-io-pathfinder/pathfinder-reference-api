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
    public class SpiritSoother : Template
    {
        public static readonly Guid ID = Guid.Parse("e5f1f8c3-776e-4aed-b460-4331ee3022cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit Soother",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0efd0edb-cda0-4273-85b9-1e896c8ccd93"), Type = TextBlockType.Text, Text = $"You are attuned to the minute sounds and sensations of restless spirits. Even if you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, you can attempt a check to find haunts that normally require you to be {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}. You still need to meet any other requirements to find the haunt." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89f6f266-5a48-4f90-be5d-f44d836482ed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
