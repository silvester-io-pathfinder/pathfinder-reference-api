using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class Bolts : Template
    {
        public static readonly Guid ID = Guid.Parse("c51ef03b-db9b-44ac-92ac-39a0c7834b95");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Bolts",
                WeaponGroupId = WeaponGroups.Instances.Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("3add4143-2b9b-4aee-988c-24072aee9d51"), "Shorter than traditional arrows but similar in construction, bolts are the ammunition used by crossbows.");
        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("e55449f1-5d59-47b0-95d1-84cbdd840715"),
                Name = "Bolts",
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
                Id = Guid.Parse("73692529-4560-47a6-988d-7e43046a44ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
