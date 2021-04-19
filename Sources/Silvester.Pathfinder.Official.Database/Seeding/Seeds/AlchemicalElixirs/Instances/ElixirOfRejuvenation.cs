using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class ElixirOfRejuvenation : AbstractAlchemicalElixirTemplate
    {
        public static readonly Guid ID = Guid.Parse("c9715348-c813-422b-af5b-e2c9a11884a9");

        protected override AlchemicalElixir GetAlchemicalElixir(AlchemicalElixirSeeder seeder)
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Elixir of Rejuvenation",
                Usage = "Held in 1 hand",
                ItemBonus = 20,
                BulkId = seeder.GetBulkByName("L").Id
            };
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Alchemical";
            yield return "Elixir";
            yield return "Consumable";
            yield return "Uncommon";
            yield return "Healing";
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b3a9903-a51c-4a10-b932-ee51026807ff"), Text = "The elixir of rejuvenation restores a creature to full health and eradicates toxins affecting it. When you drink this elixir, you’re restored to your maximum Hit Points, and all afflictions of 20th level or lower affecting you are removed." };
            yield return new TextBlock { Id = Guid.Parse("1bc9c603-c18b-4898-add5-8e6533dbbeb0"), Text = "You can instead administer this elixir to a creature that has been dead for a week or less. When you do, that creature is instantly brought back to life with 1 Hit Point and no spell slots, Focus Points, or other daily resources." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8f2ff716-0305-4642-875f-9325f583b4a8"),
                PotionPotencyId = seeder.GetPotionPotencyByName("Unclassified").Id,
                Level = 20,
                Benefits = "The Elixir of Rejuvenation only exists as a single unclassified potency."
            };
        }

        protected override SourcePage? GetSourcePage(AlchemicalElixirSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b04b283-38a7-4557-ad92-2128845aab30"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }

        protected override IEnumerable<AlchemicalElixirCraftingRequirement> GetCraftingRequirements(AlchemicalElixirSeeder seeder)
        {
            yield return new AlchemicalElixirCraftingRequirement { Id = Guid.Parse("1209cba6-d323-4476-a577-8d461bf3e0ce"), Text = "Philosopher's Stone" };
            yield return new AlchemicalElixirCraftingRequirement { Id = Guid.Parse("cc69ec58-f925-487a-9c59-24c7d51649fe"), Text = "True Elixir of Life" };
        }
    }
}
