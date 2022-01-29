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
    public class Rehydration : Template
    {
        public static readonly Guid ID = Guid.Parse("ea1c6d8b-2332-41be-8a27-b63275c92f9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rehydration",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e83b5c1-8e91-4e6a-bb93-0c8b852fbcd1"), Type = TextBlockType.Text, Text = $"You surround your body with a thin layer of water drawn from the moisture in the air. You can spend one hour resting to rehydrate your gills and skin, which counts as submerging your body in water. At the GM's discretion, incredibly dry areas, such as deserts, might not have enough moisture in the air for your Rehydration to work." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Azarketi.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Transmutation.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Water.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8778b250-46d9-4a3c-90d9-6ad7a16c6ea0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
