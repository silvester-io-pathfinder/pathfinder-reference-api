using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class Handcuffs : Template
    {
        public static readonly Guid ID = Guid.Parse("9983c552-a302-4e9d-bd9d-d9380407a934");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Handcuffs",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("4e8a46cf-841d-40a2-add4-03f3ac9e9cb1"), "Developed in Absalom and rarely used except by police forces in major cities due to their significant cost, handcuffs possess a ratcheting lock system in each cuff that allows them to be quickly cinched down on a captive's limbs, even if they're actively resisting.");;
            builder.Text(Guid.Parse("97b8168b-b0d4-4082-81b3-cbba47d9a0a4"), "To apply handcuffs, you must first grab or restrain your opponent, then attempt an Athletics check against the opponent's Fortitude DC. On a success, you lock one of the cuffs around your opponent's wrist. You can lock the other cuff to yourself or a stationary object within reach as an Interact action; to lock it to another creature (either the same opponent you just cuffed or a separate creature altogether), you must first grab or restrain that creature, as before, and then make an Athletics check against its Fortitude DC. The DC to make the Athletics check against your own wrist is 5, or 10 for an unattended object.");;
            builder.Text(Guid.Parse("19d14bff-42ca-4172-8cbc-356a4c6ca560"), "If you bind a creature to itself, it takes the same penalties as those imposed by manacles. If you bind a creature to another creature (including yourself), the two creatures are locked together and must remain in adjacent spaces, and both creatures gain the clumsy 1 condition as long as they are handcuffed. If you lock a creature to an immobile object, such as a bar or tree, the creature is immobilized. (For creatures with an unusual physiology such as more or fewer limbs, the GM determines what effects handcuffs have, if any.)");;
            builder.Text(Guid.Parse("d5445d48-c8e6-4dc8-af70-9203ea51289d"), "Handcuffs are unlocked via a key and are easier to slip out of than ordinary manacles. The chain between handcuffs can be Broken Open with a single Athletics check.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("b5e2ae9d-13e4-4d87-a243-cbd5b3ac46d3"),
                Name = "Handcuffs (Average)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 3,
                Price = 3000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("ed99a39c-935d-42fd-a8dd-c4c03b07ad0f"), "Escaping requires two successful DC 27 Thievery checks, and the Athletics DC to Break Open the chain between handcuffs is 30.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("2c4c99fb-dee1-4d3d-afd5-93e5b586349d"),
                Name = "Handcuffs (Good)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 9,
                Price = 35000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("62aeeb3c-619d-42ac-9642-673b187bd430"), "Escaping requires three successful DC 30 Thievery checks, and the Athletics DC to Break Open the chain between handcuffs is 35.")
                    .Build()
            };

            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("d235ad1f-7f89-4957-a1cf-20bcfbdd0bc5"),
                Name = "Handcuffs (Superior)",
                Usage = "Held in 1 hand.",
                Hands = "1",
                Level = 17,
                Price = 600000,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("c443686d-7bf4-4015-ac5c-9cb0f518dbce"), "Escaping requires four successful DC 40 Thievery checks, and the Athletics DC to Break Open the chain between handcuffs is 45.")
                    .Build()
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("69c91024-802d-4a2d-a56a-bd3aca512dcc"),
                SourceId = Sources.Instances.Pathfinder157.ID,
                Page = 77
            };
        }
    }
}
