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
    public class Dustsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("9d9f16d9-200b-4938-9fb4-788b22b03618");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dustsoul",
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
            yield return new TextBlock { Id = Guid.Parse("2897e717-d50b-4928-a206-2c8496b1500f"), Type = TextBlockType.Text, Text = $"Your earth elemental ancestor's influence manifests in you as dust and dirt, like the soil of a field or the hot desert sands. You gain the trained proficiency rank in Survival. If you would automatically become trained in Survival (from your background or class, for example), you instead become trained in a skill of your choice. You can sustain yourself on dirt and ash instead of normal food and water." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fe14a88-5d02-4200-93a6-06cd3ded99c4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
