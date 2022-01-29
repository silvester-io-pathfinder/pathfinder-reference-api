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
    public class SpiritualExplorer : Template
    {
        public static readonly Guid ID = Guid.Parse("c7c5b6ae-eefb-481d-b597-5182d8380303");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spiritual Explorer",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c1243740-0be6-430f-83d9-9da8b83bd636"), Type = TextBlockType.Text, Text = $"You're familiar with the danger that lingering spirits can pose to an unwary adventurer, and you're particularly attuned to their presence. Even if you aren't {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)} in exploration mode, you can attempt a check to find haunts that normally require you to {ToMarkdownLink<Models.Entities.Activity>("Search", Activities.Instances.Search.ID)} for them. You still need to meet any other requirements to find a particular haunt." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("439036c6-fad8-4c0f-9642-d0213d052ae9"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45dca98d-38d0-4972-91a6-20b5f5970b78"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
