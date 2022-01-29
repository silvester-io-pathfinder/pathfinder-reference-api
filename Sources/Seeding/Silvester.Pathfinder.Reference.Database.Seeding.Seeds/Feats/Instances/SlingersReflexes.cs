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
    public class SlingersReflexes : Template
    {
        public static readonly Guid ID = Guid.Parse("6236d0d5-17fd-41be-b7cd-4ad3117b4b27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Slinger's Reflexes",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aac286f4-d563-404a-a8ea-430c1d4319b0"), Type = TextBlockType.Text, Text = $"Your ability to react to unexpected circumstances is preternaturally sharp. At the start of each enemy's turn, you gain an additional reaction you can use on only that turn to use a gunslinger reaction." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("869a31bc-ed96-4c87-b4e7-dfe75a09e593"), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71a69160-b9f3-48e3-8b50-45be054c7144"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
