using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class SlingBullets : Template
    {
        public static readonly Guid ID = Guid.Parse("550fe4e4-da65-4660-93bb-03676930ac11");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Sling Bullets",
                WeaponGroupId = WeaponGroups.Instances.Sling.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fb128e6f-7694-490d-b2e6-466fa06fea53"), "These are small metal balls, typically either iron or lead, designed to be used as ammunition in slings.");
        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("42f58064-fd59-48e6-8325-9234884e4251"),
                Name = "Sling Bullets",
                Price = 1,
                BatchAmount = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("489605ad-2019-4607-b4b5-dd06a348fb01"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
