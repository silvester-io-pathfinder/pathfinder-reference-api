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
    public class Sunrod : AbstractAlchemicalToolTemplate
    {
        public static readonly Guid ID = Guid.Parse("cad37b1b-7d1e-4a1a-acb4-23a9814683ab");

        protected override AlchemicalTool GetAlchemicalTool(AlchemicalToolSeeder seeder)
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Sunrod",
                ItemLevel = 1,
                Price = 300,
                Usage = "Held in 1 hand",
                BulkId = seeder.GetBulkByName("L").Id,
                ActionId = Interact.ID,
                ActionTypeId = seeder.GetActionTypeByName("One Action").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Consumable";
            yield return "Light";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8238f38f-f33e-4252-9f51-f0ec7ae0b938"), Type = TextBlockType.Text, Text = "This 1-foot-long, gold-tipped rod glows after it’s struck on a hard surface. For the next 6 hours, it sheds bright light in a 20-foot radius (and dim light to the next 40 feet)." };
        }

        protected override SourcePage? GetSourcePage(AlchemicalToolSeeder seeder)
        {
            return new SourcePage 
            {
                Id = Guid.Parse("64fa1397-8f70-4a14-9cfa-8f078fc31383"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 554
            };
        }

    }
}
