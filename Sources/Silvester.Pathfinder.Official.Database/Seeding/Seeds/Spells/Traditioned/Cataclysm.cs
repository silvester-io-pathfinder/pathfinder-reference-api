using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Cataclysm : Template
    {
        public static readonly Guid ID = Guid.Parse("75ed7032-7a88-407c-a7d5-a4bd3e905ba1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Cataclysm",
                Level = 10,
                Range = "1000 feet.",
                Area = "60-foot burst.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b14accb0-bbb3-4cef-8c2f-0d42c209292d"), Type = Utilities.Text.TextBlockType.Text, Text = "You call upon the unimaginable power of world-ending cataclysms, ripping a small piece of each cataclysm and combining them together into one horrifically powerful attack. The following effects come down upon all creatures in the area. Treat the resistances of creatures in the area as if they were 10 lower for the purpose of determining the cataclysm’s damage." };
            yield return new TextBlock { Id = Guid.Parse("cf2e53f8-3cc3-4b6a-b9b4-c923c6d7aacb"), Type = Utilities.Text.TextBlockType.Text, Text = "Each creature attempts one basic Reflex save that applies to all five types of damage." };
            yield return new TextBlock { Id = Guid.Parse("381ec139-c96a-41af-8fce-22ca8c5dbeb2"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Flesh-dissolving acid rain deals 3d10 acid damage." };
            yield return new TextBlock { Id = Guid.Parse("dcd40c58-78c7-4be6-8ba9-8ab86f679fb3"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "A roaring earthquake shakes and bludgeons creatures on the ground, dealing 3d10 bludgeoning damage." };
            yield return new TextBlock { Id = Guid.Parse("6bd47ee1-f4dc-4c6c-97bf-04c1b84e55d1"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "A blast of freezing wind deals 3d10 cold damage." };
            yield return new TextBlock { Id = Guid.Parse("077a48c4-a7b5-40db-8538-fc69166f8900"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Incredible lightning lashes the area, dealing 3d10 electricity damage." };
            yield return new TextBlock { Id = Guid.Parse("c8c78ca8-a307-42eb-bb47-0b63589ba7e3"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Beating winds churn across the sky, dealing 3d10 bludgeoning damage to creatures flying in the area." };
            yield return new TextBlock { Id = Guid.Parse("4ed0277b-81ff-4863-b844-79de8e86bc7e"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "An instant tsunami sweeps over creatures in the area, dealing 3d10 bludgeoning damage with the water trait (doubled for creatures swimming in the area)." };
            yield return new TextBlock { Id = Guid.Parse("4ed9cd14-123d-4859-9255-c36eac8a062e"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "A massive wildfire burns in a sudden inferno, dealing 3d10 fire damage." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Cold.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Electricity.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb36ef09-9820-4157-8e71-e4f5d01a27f7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 322
            };
        }
    }
}
