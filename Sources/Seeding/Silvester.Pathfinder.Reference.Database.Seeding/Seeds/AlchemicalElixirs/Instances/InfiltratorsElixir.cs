using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class InfiltratorsElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("f8b7608f-3330-494d-8203-64cb7aeaa477");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Infiltrator's Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 2,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5c24f746-2f04-48a2-9b74-ab5c70e42203"), Text = "Favored by spies and tricksters, an infiltrator’s elixir is used to alter your appearance. When imbibed, you take the shape of a humanoid creature of your size, but different enough so you might be unrecognizable. If you aren’t a humanoid, you might take on a form more similar to your own, at the GM’s discretion." };
            yield return new TextBlock { Id = Guid.Parse("1e77fd3e-28cf-47ca-a2e5-085bf9673e30"), Text = "The creator of the elixir decides the basics of the appearance you transform into when you imbibe the elixir, including eye color, skin tone, and hair color. The elixir can’t change your form into that of a specific person. After the form takes hold, you retain it for the next 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("7ea16d23-375f-4b4e-8400-35d31a29f574"), Text = "Drinking this elixir counts as setting up a disguise to Impersonate. You gain a +4 status bonus to your Deception DC to avoid others seeing through your disguise, and you add your level to this DC even if untrained." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("747d368f-bf50-4339-91f8-453352f91260"),
                PotionPotencyId = Potencies.Instances.Unclassified.ID,
                Level = 2,
                Price = 6,
                Benefits = "The Infiltrator's Elixir only exists as a single unclassified potency."
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57e30628-306c-423f-9d3c-5a6aa4904952"),
                SourceId = CoreRulebook.ID,
                Page = 548
            };
        }
    }
}
