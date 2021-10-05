using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class Antiplague : Template
    {
        public static readonly Guid ID = Guid.Parse("c0369185-db16-46ad-9ac7-c4e269e9a0a8");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Antiplague",
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
            yield return Traits.Instances.Healing.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("743b8c94-0516-4c3d-9c02-6e54afceab7d"), Text = "Antiplague can fortify the body’s defenses against diseases. Upon drinking an antiplague, you gain an item bonus to Fortitude saving throws against diseases for 24 hours; this applies to your daily save against a disease’s progression." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("4154b59f-698b-4491-804b-e00f53decb63"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 300,
                Benefits = "You gain a +2 item bonus.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("1696086f-6b34-4562-adb4-82a41ff3c7b0"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 6,
                Price = 3500,
                Benefits = "You gain a +3 item bonus.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("2070f995-d30d-49df-b813-74f5e86fee94"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 10,
                Price = 16000,
                Benefits = "You gain a +4 item bonus.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("0415f0aa-1460-4dd3-9c11-2ce089552a15"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 14,
                Price = 67500,
                Benefits = "You gain a +4 item bonus, and when you drink the antiplague, you can immediately attempt a saving throw against one disease of 14th level or lower affecting you. If you succeed, you are cured of the disease.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1ef3438b-f3b0-4362-85bf-3d1f55ec01ac"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
