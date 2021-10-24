using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Actions.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.AlchemicalElixirs.Instances
{
    public class BestialMutagen : Template
    {
        public static readonly Guid ID = Guid.Parse("1a2e2a1c-f468-48ec-b023-e81756740a11");

        protected override AlchemicalElixir GetAlchemicalElixir()
        {
            return new AlchemicalElixir
            {
                Id = ID,
                ActionId = Interact.ID,
                Name = "Bestial Mutagen",
                Usage = "Held in 1 hand",
                Benefit = "You gain an item bonus to Athletics checks and unarmed attack rolls. You gain a claw unarmed attack with the agile trait and a jaws unarmed attack.",
                Drawback = "You take a –1 penalty to AC and a –2 penalty to Reflex saves.",
                ItemBonus = 1,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Alchemical.ID;
            yield return Traits.Instances.Elixir.ID;
            yield return Traits.Instances.Consumable.ID;
            yield return Traits.Instances.Mutagen.ID;
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("029c1cd3-93f2-472e-90a1-7f67847a6752"), Text = "Your features transform into something bestial and you take on muscle mass, but your lumbering form is clumsy." };
        }

        protected override IEnumerable<AlchemicalElixirPotencyBinding> GetPotencies()
        {
            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("8174165c-3f20-49c8-98aa-a9a26f730ce0"),
                PotionPotencyId = Potencies.Instances.Lesser.ID,
                Level = 1,
                Price = 400,
                Benefits = "You gain a +1 item bonus, your claw deals 1d4 slashing damage, your jaws deal 1d6 piercing damage, and the duration is 1 minute.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("d44d57f8-b3f3-494a-8ee0-4e8ac3a1aa1b"),
                PotionPotencyId = Potencies.Instances.Moderate.ID,
                Level = 3,
                Price = 1200,
                Benefits = "You gain a +2 item bonus, your claw deals 1d6 slashing damage, your jaws deal 1d8 piercing damage, and the duration is 10 minutes.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("fb2d067c-923e-468a-99bd-f92fa90011e3"),
                PotionPotencyId = Potencies.Instances.Greater.ID,
                Level = 11,
                Price = 30000,
                Benefits = "You gain a +3 item bonus, your claw deals 1d8 slashing damage, your jaws deal 1d10 piercing damage, and the duration is 1 hour.",
            };

            yield return new AlchemicalElixirPotencyBinding
            {
                Id = Guid.Parse("b71b9fc1-1ec2-4c5e-85cf-83ab3b3722e3"),
                PotionPotencyId = Potencies.Instances.Major.ID,
                Level = 17,
                Price = 300000,
                Benefits = "You gain a +4 item bonus, your claw deals 1d8 slashing damage, your jaws deal 1d10 piercing damage, and the duration is 1 hour. You gain weapon specialization with the claws and jaws, or greater weapon specialization, if you already have weapon specialization with these unarmed attacks.",
            };
        }

        protected override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b71b9fc1-1ec2-4c5e-85cf-83ab3b3722e3"),
                SourceId = CoreRulebook.ID,
                Page = 546
            };
        }
    }
}
