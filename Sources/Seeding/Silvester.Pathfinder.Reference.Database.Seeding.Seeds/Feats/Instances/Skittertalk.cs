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
    public class Skittertalk : Template
    {
        public static readonly Guid ID = Guid.Parse("77be8b29-3457-4fc9-8d92-c2e1ae3c5c68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skittertalk",
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
            yield return new TextBlock { Id = Guid.Parse("ae3a38e3-97d0-4c68-a025-d0191d10eff1"), Type = TextBlockType.Text, Text = $"You can ask questions of, receive answers from, and use the Diplomacy skill with spiders and other arachnids. The GM determines which creatures count for this ability." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("7ec7181d-627a-4c5d-862c-b166e33536e2"), Traits.Instances.Anadi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6aad67f-d529-43b0-bdc6-6b660c9d9392"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
