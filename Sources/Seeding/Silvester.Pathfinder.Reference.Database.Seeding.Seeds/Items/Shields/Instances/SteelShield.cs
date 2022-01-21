using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Shields.Instances
{
    public class SteelShield : Template
    {
        public static readonly Guid ID = Guid.Parse("ea71685d-64f3-4374-815d-2710b6a1579b");

        protected override Shield GetShield()
        {
            return new Shield
            {
                Id = ID,
                Name = "Steel Shield"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d6cd8f12-9dea-414e-9391-153c6bf81aeb"), "Like wooden shields, steel shields come in a variety of shapes and sizes. Though more expensive than wooden shields, they are much more durable.");;
        }

        protected override IEnumerable<ShieldVariant> GetShieldVariants()
        {
            yield return new ShieldVariant
            {
                Id = Guid.Parse("14790a6c-371e-427b-920c-6808bca86c50"),
                Name = "Steel Shield",
                Price = 200,
                ArmorClassBonus = 2,
                SpeedPenalty = 0,
                Hardness = 5,
                Hands = "1",
                HitPoints = 20,
                BrokenThreshold = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5fde09c-367c-454f-ad51-7e09058d0a8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 277
            };
        }
    }
}
