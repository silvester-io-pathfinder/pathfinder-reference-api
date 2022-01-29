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
    public class DjinniMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("41905134-81a3-4fbd-83b9-be1c7ca8559b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Djinni Magic",
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
            yield return new TextBlock { Id = Guid.Parse("c5b7bb2a-ed69-4273-b4d1-5584d112a9d9"), Type = TextBlockType.Text, Text = $"The magic of djinn runs through your blood. You can cast {ToMarkdownLink<Models.Entities.Spell>("gust of wind", Spells.Instances.GustOfWind.ID)} and {ToMarkdownLink<Models.Entities.Spell>("invisibility", Spells.Instances.Invisibility.ID)} once per day each as 2nd-level arcane innate spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Sylph.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5fb8147-8e98-4d90-a3d1-f9b59370916b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
