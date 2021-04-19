using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalTools.Instances
{
    public class Smokestick : AbstractAlchemicalToolTemplate
    {
        public static readonly Guid ID = Guid.Parse("3c31b16b-1804-4e2e-ba66-9bb8faaca03e");

        protected override AlchemicalTool GetAlchemicalTool(AlchemicalToolSeeder seeder)
        {
            return new AlchemicalTool
            {
                Id = ID,
                Name = "Smokestick",
                ItemLevel = 1,
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
            yield return new TextBlock { Id = Guid.Parse("9908505d-e79b-42e7-8f5a-dd4ec3165054"), Type = TextBlockType.Text, Text = "With a sharp twist of this item, you instantly create a screen of thick, opaque smoke in a burst centered on one corner of your space. All creatures within that area are concealed, and all other creatures are concealed to them. The smoke lasts for 1 minute or until dispersed by a strong wind." };
        }

        protected override IEnumerable<AlchemicalToolPotencyBinding> GetPotencies(AlchemicalToolSeeder seeder)
        {
            yield return new AlchemicalToolPotencyBinding
            {
                Id = Guid.Parse("44ea3349-f059-4d50-ab21-6076b0d3a05a"),
                PotencyId = seeder.GetAlchemicalToolPotencyByName("Lesser").Id,
                Level = 1,
                Price = 300,
                Benefits = "The radius of the burst is 5 feet."
            };

            yield return new AlchemicalToolPotencyBinding
            {
                Id = Guid.Parse("21dc61b1-76f2-437e-9475-e2ab515c606f"),
                PotencyId = seeder.GetAlchemicalToolPotencyByName("Greater").Id,
                Level = 7,
                Price = 5300,
                Benefits = "The radius of the burst is 20 feet."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalToolSeeder seeder)
        {
            return new SourcePage 
            {
                Id = Guid.Parse("fadcc111-0da1-42d0-b68d-80a65ab516dd"),
                SourceId = CoreRulebook.ID,
                Page = 554
            };
        }

    }
}
