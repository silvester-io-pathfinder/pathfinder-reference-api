using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ItemCategories.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WornItems.Instances
{
    public class XXTemplate : Template
    {
        public static readonly Guid ID = Guid.Parse("e07e4c7f-3742-4881-a2ec-87382481fe7e");
        
        protected override WornItem GetWornItem()
        {
            return new WornItem
            {
                Id = ID, 
                Name = "Voyager's Pack",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("37a78eef-f717-47f3-bb63-95ddf8dd413c"), "This leather rucksack has icons burned into it, and every time it's taken to a plane it hasn't been to before, a new icon representing that plane scorches into the surface. The pack grants you a +3 bonus to Survival checks. It also enables you to see the magical traces of creatures' passage, allowing you to Track a creature that has teleported. The GM sets the DC of this check, usually using the level and DC of the teleportation spell. This lets you find the location of the creature's destination, and you can use that destination when casting teleport or activating the pack, even though you don't know what it looks like.");
            builder.Text(Guid.Parse("a9fb6993-7bf1-4bbd-a9f9-15f9f10ec927"), "The pack contains an extradimensional space with the same properties as a type II bag of holding. This space contains the contents of a climber's kit. If any components of that kit are removed and not returned, they return to the pack at dawn each day.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("20c39011-efc5-4e6b-bf09-01b4eefd2078"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("0110333a-1fb0-44da-840d-071779e22f61"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("9c5d71de-0c93-459b-a026-fd2d727a0049"), Traits.Instances.Invested.ID);
            builder.Add(Guid.Parse("2e7ee557-48a0-4223-9ed8-2d337f380a54"), Traits.Instances.Magical.ID);
        }

        protected override IEnumerable<WornItemVariant> GetWornItemVariants()
		{
			yield return new WornItemVariant
			{
				Id = Guid.Parse("ab4d88ab-82af-48ac-8d1b-7544e36e4bc5"),
				Name = "Voyager's Pack",
                Usage = "Worn backpack.",
				Level = 17,
				Price = 1480000,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                     .Add(Guid.Parse("b205ab84-092a-48a3-8fac-1e49ffd3c66a"), ActionTypes.Instances.NoAction.ID, name: "Activate", action =>
                     {
                         action
                             .Kind("10 minutes (Command, Envision, Interact)")
                             .Details(builder =>
                             {
                                 builder.Text(Guid.Parse("7bd40359-efce-41fb-bd75-773ba07a1ea4"), "As you activate the pack, you can harness up to four willing creatures to the ropes on the pack. At the end of the activation time, the pack casts a 7th-level plane shift or teleport spell, transporting you and everyone attached to the pack. Attempt a DC 45 Survival check. On a success, you arrive 25 miles off target using plane shift or halve the distance you're off-target with teleport. On a critical success, you arrive exactly on target.");
                             });
                     })
                    .Build()
			};
		}

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb68f095-7d5c-487f-956e-c24e3528f969"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 617
            };
        }
    }
}
