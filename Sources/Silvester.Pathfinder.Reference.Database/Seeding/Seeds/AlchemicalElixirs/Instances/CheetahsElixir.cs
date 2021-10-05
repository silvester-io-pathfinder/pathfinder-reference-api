using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class CheetahsElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("7a89776c-ffcc-4766-8ddb-d0d6f2227c30");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Cheetah's Elixir",
                Usage = "Held in 1 hand",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3d0b8fa-4656-44c2-86ad-2247cc2326fd"), Text = "Enzymatic compounds in this elixir strengthen and excite the muscles in your legs. You gain a status bonus to your Speed for the listed duration." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("fe4a4297-984f-492d-b46c-09a59eeadd81"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 300,
                Benefits = "The bonus is +5 feet, and the duration is 1 minute.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("45cdabed-781e-4476-810d-3972cd2a68c1"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 5,
                Price = 2500,
                Benefits = "The bonus is +10 feet, and the duration is 10 minutes.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("a5799229-afdb-4118-910f-000a05eb7681"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 9,
                Price = 11000,
                Benefits = "The bonus is +10 feet, and the duration is 1 hour.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35bda9da-c238-43e3-8446-b5e2ebefdae1"),
                SourceId = CoreRulebook.ID,
                Page = 547
            };
        }
    }
}
