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
    public class MetalVeinedStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("332d5ab3-5f07-49e0-8fed-616f1bbedd25");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Metal-Veined Strikes",
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
            yield return new TextBlock { Id = Guid.Parse("95a94877-33f6-40c8-bced-381cb8b6622f"), Type = TextBlockType.Text, Text = $"Metallic veins grow throughout your body, giving your unarmed attacks a metallic sheen. Choose either cold iron or silver. Your unarmed attacks are treated as the chosen type of metal." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("33e187df-2839-4be5-9d91-55f688f18190"), Traits.Instances.Oread.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b74bba4-5766-42b8-b3fd-af4b89e18dbb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
