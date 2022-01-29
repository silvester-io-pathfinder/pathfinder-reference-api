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
    public class CaptivatingCuriosity : Template
    {
        public static readonly Guid ID = Guid.Parse("3b867475-41db-425c-be91-44c281e1db58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Captivating Curiosity",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("64260bd4-1c72-450e-ae92-fb48bedc5698"), Type = TextBlockType.Text, Text = $"You can snare the attentions of onlookers with your unique appearance. You can cast {ToMarkdownLink<Models.Entities.Spell>("enthrall", Spells.Instances.Enthrall.ID)} as a 3rd-level occult innate spell once per day." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Fleshwarp.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("769b4748-5d6a-4970-85e2-971d4ce3fafc"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
