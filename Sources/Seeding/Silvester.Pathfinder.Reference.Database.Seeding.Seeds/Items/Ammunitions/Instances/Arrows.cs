using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class Arrows : Template
    {
        public static readonly Guid ID = Guid.Parse("e784b731-7bb1-4e51-b438-3e88eb542a41");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Arrows",
                WeaponGroupId = WeaponGroups.Instances.Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c35ddb1a-38bd-404c-bece-a9e21d76658a"), "These projectiles are the ammunition for bows. The shaft of an arrow is made of wood. It is stabilized in flight by fletching at one end and bears a metal head on the other.");
        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("484ef5cc-8e4f-4557-a002-f7800cf56c35"),
                Name = "Arrows",
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
                Id = Guid.Parse("77284f4c-a449-4276-99df-e9aa9222ff5b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
