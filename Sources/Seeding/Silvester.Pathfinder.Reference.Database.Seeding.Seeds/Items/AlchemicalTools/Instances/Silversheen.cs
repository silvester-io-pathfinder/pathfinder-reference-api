using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AlchemicalTools.Instances
{
    public class Silversheen : Template
    {
        public static readonly Guid ID = Guid.Parse("3707bdeb-7db4-4473-b963-f9adc2f2c1fa");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Silversheen",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("10164353-c33e-411e-b631-26a19438ab0a"), "A silvery paste that can be used to coat weaponry or ammunition, making it count as silver instead of it's normal material for nay physical damage it deals. Silversheen spoils quickly, so once you open a vial, you must use it at at once, rather than saving it.");;
        }

        protected override IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants()
        {
            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("d0cfca9c-dd18-464f-85b7-169306bedd60"),
                Name = "Silversheen",
                Level = 2,
                Price = 500,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3a02b38a-d41f-4ed4-8042-6cac6eab8a8a"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("305d88f5-2356-4fdd-9e79-822b18d9422e"), "You can slather the paste onto one melee weapon, one thrown weapon, or 10 pieces of ammunition, causing it to count as silver for the next hour.");
                            });
                    })
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("99efdc1a-1dd1-4de9-9859-29aedc9bee80"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("bc6d003c-2e6a-4c38-a39d-7b1589896521"), Traits.Instances.Consumable.ID);
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("681100fd-185f-4a99-9f27-58ec73c5b481"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
