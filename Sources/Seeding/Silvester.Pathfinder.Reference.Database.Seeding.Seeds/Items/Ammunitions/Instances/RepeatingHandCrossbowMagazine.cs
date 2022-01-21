using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Ammunitions.Instances
{
    public class RepeatingHandCrossbowMagazine : Template
    {
        public static readonly Guid ID = Guid.Parse("5ee1520e-e377-4855-8e73-81ebee4c146d");

        protected override Ammunition GetAmmunition()
        {
            return new Ammunition
            {
                Id = ID,
                Name = "Repeating Hand Crossbow Magazine",
                WeaponGroupId = WeaponGroups.Instances.Bow.ID,
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d05c74a4-bdeb-4d07-8327-471c974e2285"), "A typical repeating hand crossbow magazine holds five bolts.");
        }

        protected override IEnumerable<AmmunitionVariant> GetAmmunitionVariants()
        {
            yield return new AmmunitionVariant
            {
                Id = Guid.Parse("230ca631-040f-47e2-90f4-d7f1507f81b5"),
                Name = "Repeating Hand Crossbow Magazine",
                Price = 90,
                BatchAmount = 5,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("91b5e6aa-fe9b-4f36-8a57-d7588c7b876f"),
                SourceId = Sources.Instances.Pathfinder165.ID,
                Page = 73
            };
        }
    }
}
