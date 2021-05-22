using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools.Instances
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
                ItemLevel = 20,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.TwoBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ActivationAddendum = "Or 1 or more days; see description."
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1b782fba-1f25-45e6-9c4e-1c5302f158f6"), Type = TextBlockType.Text, Text = "An alchemist with the Craft Philosopher’s Stone feat can create a philosopher’s stone once per month by spending 1 batch of infused reagents during their daily preparations using the advanced alchemy class feature. This is the only way to create a philosopher’s stone." };
            yield return new TextBlock { Id = Guid.Parse("aae5d4ac-27ba-4142-8927-313f73134489"), Type = TextBlockType.Text, Text = "At a glance, a philosopher’s stone appears to be an ordinary, sooty piece of natural rock.Breaking the rock open with a Force Open action(DC 35) reveals a cavity at the stone’s heart.The cavity is lined with a rare type of quicksilver that can transmute base metals into precious metals or create an elixir of rejuvenation(page 548)." };
            yield return new TextBlock { Id = Guid.Parse("0906dbf5-774b-4fbc-93b4-785e00c0e9be"), Type = TextBlockType.Text, Text = "To use the quicksilver, you must be legendary in Crafting and have the Alchemical Crafting feat.You can then use the stone’s quicksilver for one of two effects:" };
            yield return new TextBlock { Id = Guid.Parse("5d0baac6-aa97-439b-9f15-f41924e85403"), Type = TextBlockType.Enumeration, Text = "You can apply the stone’s quicksilver to an infused true elixir of life using an Interact action.This turns the elixir into an infused elixir of rejuvenation instantaneously.This doesn’t require any crafting time or additional materials." };
            yield return new TextBlock { Id = Guid.Parse("7176e4f6-3ecd-4af5-88b1-77adb4690dab"), Type = TextBlockType.Enumeration, Text = "You can spend up to a month of downtime applying the quicksilver either to iron to create silver or to leadto create gold.Treat this as a 20th - level task to Earn Income using Crafting, except that you create 500 gp worth of your chosen metal per day on a success or 750 gp worth per day on a critical success." };
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
