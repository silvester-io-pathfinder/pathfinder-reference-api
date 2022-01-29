using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Doll : Template
    {
        public static readonly Guid ID = Guid.Parse("7f6ffed6-9a29-4b04-9c9c-fbad7a407d08");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Doll",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("e669f08b-9316-45bb-b454-b392367e8517"), "Dolls are found throughout Golarion in a wide variety of forms. Among the most common are miniature painted figurines, plush animals crafted from fur and stuffed with cotton, porcelain dolls with fine clothing and silky hair, fabric hand puppets, and elaborate marionettes.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("661051a7-d8c4-4958-9f13-dae8147d4ce1"),
                Name = "Doll",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 0,
                Price = 10,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("79dee7aa-8cc0-49fc-8b80-d2fa9660af64"),
                Name = "Surprise Doll",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 1,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                   .Text(Guid.Parse("a32dbedf-854d-48e2-8ba1-c246f362d981"), "These dolls contain a hidden compartment or pouch capable of holding a single object of up to light Bulk - typically a bell, rattle, or dried flowers.")
                  .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("f87b2dd8-889c-446b-858c-35fadf3b7366"),
                Name = "Exquisite Surprise Doll",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 2,
                Price = 1000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("5f32730f-f504-4122-84ee-80d10e59f26b"), "Hiding an object inside this beautifully crafted surprise doll grants you a +1 item bonus on Stealth checks made to Conceal an Item, as the compartment is particularly well-hidden and weighted to ensure the doll doesn't feel off-balance with an item inside.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32181fe5-0f56-49ac-ae96-a8f9bce21f06"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 58
            };
        }
    }
}
