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
    public class TwoWeaponFusillade : Template
    {
        public static readonly Guid ID = Guid.Parse("164492b5-8a38-427b-a534-f50104d1a1a9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Two-Weapon Fusillade",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cacd3cb7-c9ac-4745-92d9-d43cf831a69d"), Type = TextBlockType.Text, Text = $"You attack with both your weapons in a furious barrage. {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} twice, once with each weapon." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5f4516da-ed0f-4a22-ab5b-d30ad9dfc702"), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse("2fab7c2c-9f06-42ec-8d9b-45cf7e12fff5"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85fdf645-74fc-41c8-b8c4-daad9dc5789f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
