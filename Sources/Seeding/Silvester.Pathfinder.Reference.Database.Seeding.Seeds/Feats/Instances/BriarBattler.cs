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
    public class BriarBattler : Template
    {
        public static readonly Guid ID = Guid.Parse("02a25143-771d-4035-994f-85383b7be464");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Briar Battler",
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
            yield return new TextBlock { Id = Guid.Parse("ce92491e-f9c4-4cf0-ad2d-ca830c397a01"), Type = TextBlockType.Text, Text = $"You've learned to use roots, crevices, uneven ground, and dense underbrush to your advantage. When you're in difficult terrain from an environmental feature, you can {ToMarkdownLink<Models.Entities.Action>("Take Cover", Actions.Instances.TakeCover.ID)}, even if the feature wouldn't ordinarily be large enough for you to {ToMarkdownLink<Models.Entities.Action>("Take Cover", Actions.Instances.TakeCover.ID)}." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fb3549bf-2d7f-4bb7-9031-0896b371474a"), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d443df2-9785-4f6e-bba9-31884450a3ff"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
