using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools.Instances
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
                ItemLevel = 2,
                Price = 500,
                Usage = "Held in 2 hands",
                BulkId = Bulks.Instances.LightBulk.ID,
                ActionId = Interact.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Consumable.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10164353-c33e-411e-b631-26a19438ab0a"), Type = TextBlockType.Text, Text = "You can slather this silvery paste onto one melee weapon, one thrown weapon, or 10 pieces of ammunition. Silversheen spoils quickly, so once you open a vial, you must use it all at once, rather than saving it. For the next hour, the weapon or ammunition counts as silver instead of its normal precious material (such as cold iron) for any physical damage it deals." };
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
