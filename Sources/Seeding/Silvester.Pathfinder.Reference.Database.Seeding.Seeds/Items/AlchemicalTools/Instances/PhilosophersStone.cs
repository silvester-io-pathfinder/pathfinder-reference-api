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
    public class PhilosophersStone : Template
    {
        public static readonly Guid ID = Guid.Parse("b6393c4f-dc42-4218-b0cd-71c78d2af105");

        protected override AlchemicalTool GetAlchemicalTool()
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Philosopher's Stone",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1b782fba-1f25-45e6-9c4e-1c5302f158f6"), "An alchemist with the Craft Philosopher's Stone feat can create a philosopher's stone once per month by spending 1 batch of infused reagents during their daily preparations using the advanced alchemy class feature. This is the only way to create a philosopher's stone.");;
            builder.Text(Guid.Parse("aae5d4ac-27ba-4142-8927-313f73134489"), "At a glance, a philosopher's stone appears to be an ordinary, sooty piece of natural rock.Breaking the rock open with a Force Open action(DC 35) reveals a cavity at the stone's heart.The cavity is lined with a rare type of quicksilver that can transmute base metals into precious metals or create an elixir of rejuvenation(page 548).");;
            builder.Text(Guid.Parse("0906dbf5-774b-4fbc-93b4-785e00c0e9be"), "To use the quicksilver, you must be legendary in Crafting and have the Alchemical Crafting feat.");;
        }

        protected override IEnumerable<AlchemicalToolVariant> GetAlchemicalToolVariants()
        {
            yield return new AlchemicalToolVariant
            {
                Id = Guid.Parse("6bd2109e-29c5-41ce-af70-b8ef647ae27b"),
                Name = "Philosopher's Stone",
                Level = 20,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.TwoBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1106fe7d-f3c1-4fd8-8068-f9746c8bfd44"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("45551136-20b6-43ab-9d43-fd0cdbd77f9f"), "You can apply the stone's quicksilver to an infused true elixir of life using an Interact action. This turns the elixir into an infused elixir of rejuvenation instantaneously. This doesn't require any crafting time or additional materials.");
                            });
                    })
                    .Add(Guid.Parse("5191a978-b3ba-473c-8ae8-4bdcc3ac8d49"), ActionTypes.Instances.NoAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("99662b07-7944-4442-aadd-ee99fb61ceac"), "You can spend up to a month of downtime applying the quicksilver either to iron to create silver or to lead to create gold. Treat this as a 20th-level task to Earn Income using Crafting, except that you create 500 gp worth of your chosen metal per day on a success or 750 gp worth per day on a critical success.");
                            });
                    })
                    .Build(),
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f1255bfa-03e2-4600-8a53-98e688075f83"), Traits.Instances.Alchemical.ID);
            builder.Add(Guid.Parse("b34c0226-ddd6-4e6f-899c-54c9705dec35"), Traits.Instances.Consumable.ID);
            builder.Add(Guid.Parse("5b0f279b-9de8-4707-963f-b078e4c9ff95"), Traits.Instances.Uncommon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage 
            {
                Id = Guid.Parse("92157e81-6f5b-41bf-82d1-32ab6b31b709"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
