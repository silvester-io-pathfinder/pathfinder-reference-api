
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class WoodenTaws : Template
    {
        public static readonly Guid ID = Guid.Parse("2981098c-b7f9-40bd-83a4-624eec7ef483");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Wooden Taws",
                WeaponGroupId = WeaponGroups.Instances.Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {

        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("c844d826-584f-4699-8ac2-073351141242"),
                Name = "Wooden Taws",
                Price = 10,
                BatchAmount = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1971ded-4ed2-4256-9dc7-4887b0867100"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
