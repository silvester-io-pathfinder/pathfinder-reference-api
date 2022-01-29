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
    public class TranquilSanctuary : Template
    {
        public static readonly Guid ID = Guid.Parse("6018aa5e-b62a-4fff-8b14-cc8c5e3a7081");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tranquil Sanctuary",
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
            yield return new TextBlock { Id = Guid.Parse("0de4cfc7-ac8e-40c7-93c9-b7b1f0d445a3"), Type = TextBlockType.Text, Text = $"Whenever possible, you follow the serene path and encourage others to do the same. You can cast {ToMarkdownLink<Models.Entities.Spell>("sanctuary", Spells.Instances.Sanctuary.ID)} once per day as a 1st-level divine innate spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2406e372-52f1-4762-acf7-3ff0b6a1d3ed"), Feats.Instances.Idyllkin.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("aec4af9b-4e38-418f-b853-45ae6171f1f3"), Traits.Instances.Aasimar.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33897e4d-37de-410c-ba7d-df2a0aedcd15"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
