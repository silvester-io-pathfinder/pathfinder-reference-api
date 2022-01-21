using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class BlowgunDarts : Template
    {
        public static readonly Guid ID = Guid.Parse("9230c1f0-09ea-4dd2-b6d4-bb0cfcbeabdd");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Blowgun Darts",
                WeaponGroupId = WeaponGroups.Instances.Dart.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bb273704-b05d-4def-b199-4bc941e1fae4"), "These thin, light darts are typically made of hardwood and stabilized with fletching of down or fur. They are often hollow so they can be used to deliver poison.");
        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("21564028-cf0b-40df-a61e-3334f58a07dd"),
                Name = "Blowgun Darts",
                Price = 5,
                BatchAmount = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("867680b0-acc3-44c6-9e1d-0abd095af230"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 281
            };
        }
    }
}
