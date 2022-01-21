using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class PortableRam : Template
    {
        public static readonly Guid ID = Guid.Parse("d037bb2f-a092-42f3-9d90-40751e2bcf87");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Portable Ram",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fe4f038c-c273-4a6d-ab9d-2df540605840"), "A portable ram is a handheld, ironshod wooden beam designed to knock open doors, gates, and other similar obstacles. You gain a +1 item bonus to checks to Force Open these obstacles.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("be6b1d05-0655-4540-8d72-6b72d372810a"),
                Name = "Portable Ram",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 3,
                Price = 2000,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("aef6cee2-8dd1-49a5-b555-36ac092c5875"),
                Name = "Portable Ram (Reinforced)",
                Usage = "Held in 2 hands.",
                Hands = "2",
                Level = 9,
                Price = 60000,
                BulkId = Bulks.Instances.ThreeBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a7affb9a-e38e-474b-9764-422439fff96e"), "A reinforced portable ram grants you a +2 item bonus to checks to Force Open obstacles.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7e47985-b184-474e-981b-1f43f961da57"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 92
            };
        }
    }
}
