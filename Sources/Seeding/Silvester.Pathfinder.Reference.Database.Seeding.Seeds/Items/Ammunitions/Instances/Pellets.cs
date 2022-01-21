using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class Pellets : Template
    {
        public static readonly Guid ID = Guid.Parse("1ec3481e-2f0a-49ee-8cac-718e0202a119");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Pellets",
                WeaponGroupId = WeaponGroups.Instances.Firearm.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("04110586-a83c-41ae-9f0c-5a37caa65ddf"), "Firearms require ammunition consisting of a projectile and black powder. A round of ammo can vary in its composition but is typically either a prepackaged paper cartridge, including wadding, bullet, and black powder, or loose shot packed in manually. Some weapons, like hand cannons and blunderbusses, can fire other materials, but their ammunition has the same Price due to the cost of the black powder. Because making rounds of firearm ammunition requires creating black powder, you need the Alchemical Crafting skill feat to make them. Firearm rounds are a valid option for magical ammunition, just like arrows or bolts. Crafting magical firearm ammunition requires you to be able to craft both alchemical and magical items.");
        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("21006838-699f-4954-9254-f212a367caf7"),
                Name = "Pellets",
                Price = 10,
                BatchAmount = 5,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("27189b6c-3e90-4765-a034-a68b1519e6aa"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 150
            };
        }
    }
}
