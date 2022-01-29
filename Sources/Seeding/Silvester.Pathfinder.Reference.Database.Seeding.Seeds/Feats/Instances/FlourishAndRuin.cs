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
    public class FlourishAndRuin : Template
    {
        public static readonly Guid ID = Guid.Parse("e9dd8e28-4c36-45bd-8ca7-039868295f65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flourish and Ruin",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2c55baa-623b-48f9-a496-d8bf4be91517"), Type = TextBlockType.Text, Text = $"You can call upon the vital essence of your spirit to restore life to your allies and call forth vines to ensnare and bludgeon your foes. You can cast {ToMarkdownLink<Models.Entities.Spell>("field of life", Spells.Instances.FieldOfLife.ID)} and {ToMarkdownLink<Models.Entities.Spell>("tangling creepers", Spells.Instances.TanglingCreepers.ID)} as 6th-level primal innate spells once per day each. You become an expert in primal spell attack rolls and primal spell DCs." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Leshy.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8462327-4846-4c66-8d30-a78b487290e7"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
