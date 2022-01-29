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
    public class CallOfTheGreenMan : Template
    {
        public static readonly Guid ID = Guid.Parse("a871ecb2-21ff-47b2-9ea6-86c74e2c8919");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Call of the Green Man",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17fa90e5-492d-41da-bf40-887258b7fdfd"), Type = TextBlockType.Text, Text = $"You can call forth nearby nature spirits to augment your body. Once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("plant form", Spells.Instances.PlantForm.ID)} as a 5th-level primal innate spell. When you reach 17th level, this spell can be heightened to 6th level." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Leshy.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("52a1156f-97f9-48d1-a3b1-851d6eacebf1"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
