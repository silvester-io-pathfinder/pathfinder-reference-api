using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class ConcealedHolster : Template
    {
        public static readonly Guid ID = Guid.Parse("123c3484-a8eb-4fcb-a92f-2d54d8d6b6b5");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Concealed Holster",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("828d4496-b02a-401e-86ba-1fee62b9d723"), "This leather holster is crafted to better hide small firearms from view. Only firearms designed for use in one hand are small enough to disguise with this holster. You gain a +1 item bonus to Stealth checks and DCs to hide or conceal a firearm or hand crossbow in this holster.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("a101a75b-d972-4e42-a1d9-76507be6caa2"),
                Name = "Concealed Holster",
                Level = 3,
                Price = 2500,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("931b00f0-eff6-4ce3-86a0-5f5d2dc3c496"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 179
            };
        }
    }
}
