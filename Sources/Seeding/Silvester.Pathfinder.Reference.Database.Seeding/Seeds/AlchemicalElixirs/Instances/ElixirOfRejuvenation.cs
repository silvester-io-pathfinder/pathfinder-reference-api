using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class ElixirOfRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("c9715348-c813-422b-af5b-e2c9a11884a9");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Elixir of Rejuvenation",
                Usage = "Held in 1 hand",
                ItemBonus = 20,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Healing.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b3a9903-a51c-4a10-b932-ee51026807ff"), Text = "The elixir of rejuvenation restores a creature to full health and eradicates toxins affecting it. When you drink this elixir, you're restored to your maximum Hit Points, and all afflictions of 20th level or lower affecting you are removed." };
            yield return new TextBlock { Id = Guid.Parse("1bc9c603-c18b-4898-add5-8e6533dbbeb0"), Text = "You can instead administer this elixir to a creature that has been dead for a week or less. When you do, that creature is instantly brought back to life with 1 Hit Point and no spell slots, Focus Points, or other daily resources." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8f2ff716-0305-4642-875f-9325f583b4a8"),
                PotionPotencyId = Potencies.Instances.Unclassified.ID,
                Level = 20,
                Benefits = "The Elixir of Rejuvenation only exists as a single unclassified potency."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b04b283-38a7-4557-ad92-2128845aab30"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }

        protected override IEnumerable<AlchemicalElixirCraftingRequirement> GetCraftingRequirements()
        {
            yield return new AlchemicalElixirCraftingRequirement { Id = Guid.Parse("1209cba6-d323-4476-a577-8d461bf3e0ce"), Text = "Philosopher's Stone" };
            yield return new AlchemicalElixirCraftingRequirement { Id = Guid.Parse("cc69ec58-f925-487a-9c59-24c7d51649fe"), Text = "True Elixir of Life" };
        }
    }
}
