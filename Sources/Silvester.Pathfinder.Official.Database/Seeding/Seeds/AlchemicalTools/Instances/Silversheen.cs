using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools.Instances
{
    public class Silversheen : AbstractAlchemicalToolTemplate
    {
        public static readonly Guid ID = Guid.Parse("3707bdeb-7db4-4473-b963-f9adc2f2c1fa");

        protected override AlchemicalTool GetAlchemicalTool(AlchemicalToolSeeder seeder)
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Silversheen",
                ItemLevel = 2,
                Price = 500,
                Usage = "Held in 2 hands",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Consumable";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10164353-c33e-411e-b631-26a19438ab0a"), Type = TextBlockType.Text, Text = "You can slather this silvery paste onto one melee weapon, one thrown weapon, or 10 pieces of ammunition. Silversheen spoils quickly, so once you open a vial, you must use it all at once, rather than saving it. For the next hour, the weapon or ammunition counts as silver instead of its normal precious material (such as cold iron) for any physical damage it deals." };
        }

        protected override SourcePage? GetSourcePage(AlchemicalToolSeeder seeder)
        {
            return new SourcePage 
            {
                Id = Guid.Parse("681100fd-185f-4a99-9f27-58ec73c5b481"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 554
            };
        }

    }
}
