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
    public class MoonMay : Template
    {
        public static readonly Guid ID = Guid.Parse("9f46d726-33ea-4d96-a1db-abc850fbbfeb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Moon May",
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
            yield return new TextBlock { Id = Guid.Parse("cf2ae57c-daa0-4908-ba0c-9c93c725af74"), Type = TextBlockType.Text, Text = $"Your mother was a moon hag, a handmaiden of Groetus, and you have a single scarlet eye and a sliver of her supernal foresight. You can cast {ToMarkdownLink<Models.Entities.Spell>("guidance", Spells.Instances.Guidance.ID)} as an occult innate cantrip. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("00b63ceb-d2eb-4ef4-a1a7-00d5ec7ed3d0"), Traits.Instances.Changeling.ID);
            builder.Add(Guid.Parse("d566517e-2f6b-4765-9084-d244dfb65d74"), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02a7676a-cd56-444d-946b-fb2237dd98eb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
