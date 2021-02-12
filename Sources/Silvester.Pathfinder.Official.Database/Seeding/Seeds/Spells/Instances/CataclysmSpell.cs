using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CataclysmSpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Two Actions";
        public override string MagicSchool => "Evocation";
        public override string SavingThrowStat => "Reflex";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("75ed7032-7a88-407c-a7d5-a4bd3e905ba1"),
                Name = "Cataclysm",
                Description = "You call upon the unimaginable power of world-ending cataclysms, ripping a small piece of each cataclysm and combining them together into one horrifically powerful attack. The following effects come down upon all creatures in the area. Treat the resistances of creatures in the area as if they were 10 lower for the purpose of determining the cataclysm’s damage.",
                Level = 10,
                Range = 1000,
                Area = "60-foot burst."
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("cf2e53f8-3cc3-4b6a-b9b4-c923c6d7aacb"), Text = "Each creature attempts one basic Reflex save that applies to all five types of damage." };
            yield return new SpellDetailBlock { Id = Guid.Parse("381ec139-c96a-41af-8fce-22ca8c5dbeb2"), Text = "- Flesh-dissolving acid rain deals 3d10 acid damage." };
            yield return new SpellDetailBlock { Id = Guid.Parse("dcd40c58-78c7-4be6-8ba9-8ab86f679fb3"), Text = "- A roaring earthquake shakes and bludgeons creatures on the ground, dealing 3d10 bludgeoning damage." };
            yield return new SpellDetailBlock { Id = Guid.Parse("6bd47ee1-f4dc-4c6c-97bf-04c1b84e55d1"), Text = "- A blast of freezing wind deals 3d10 cold damage." };
            yield return new SpellDetailBlock { Id = Guid.Parse("077a48c4-a7b5-40db-8538-fc69166f8900"), Text = "- Incredible lightning lashes the area, dealing 3d10 electricity damage." };
            yield return new SpellDetailBlock { Id = Guid.Parse("c8c78ca8-a307-42eb-bb47-0b63589ba7e3"), Text = "- Beating winds churn across the sky, dealing 3d10 bludgeoning damage to creatures flying in the area." };
            yield return new SpellDetailBlock { Id = Guid.Parse("4ed0277b-81ff-4863-b844-79de8e86bc7e"), Text = "- An instant tsunami sweeps over creatures in the area, dealing 3d10 bludgeoning damage with the water trait (doubled for creatures swimming in the area)." };
            yield return new SpellDetailBlock { Id = Guid.Parse("4ed9cd14-123d-4859-9255-c36eac8a062e"), Text = "- A massive wildfire burns in a sudden inferno, dealing 3d10 fire damage." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Arcane";
            yield return "Primal";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Acid";
            yield return "Air";
            yield return "Cold";
            yield return "Earth";
            yield return "Electricity";
            yield return "Evocation";
            yield return "Fire";
            yield return "Water";
        }
    }
}
