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
    public class Regrowth : Template
    {
        public static readonly Guid ID = Guid.Parse("65a3d691-f047-4707-a9dc-59f00cfa6507");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Regrowth",
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
            yield return new TextBlock { Id = Guid.Parse("90c02413-4a56-4b1c-89d2-c9453393d7e2"), Type = TextBlockType.Text, Text = $"Your command over your vital essence allows you or an ally to recover from grievous wounds. You can cast {ToMarkdownLink<Models.Entities.Spell>("regenerate", Spells.Instances.Regenerate.ID)} as a 7th-level primal innate spell once per day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Leshy.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("543ca425-20ec-45cc-9303-dfc85288ab96"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
