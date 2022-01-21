using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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
            yield return new TextBlock { Id = Guid.Parse("b14accb0-bbb3-4cef-8c2f-0d42c209292d"), Type = Utilities.Text.TextBlockType.Text, Text = "You call upon the unimaginable power of world-ending cataclysms, ripping a small piece of each cataclysm and combining them together into one horrifically powerful attack. The following effects come down upon all creatures in the area. Treat the resistances of creatures in the area as if they were 10 lower for the purpose of determining the cataclysm's damage." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("47770827-99c2-439c-a88a-c4c2012107b1"), Traits.Instances.Acid.ID);
            builder.Add(Guid.Parse("15b69d47-47d7-4f93-b4f1-949dfada8f39"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("e934ab20-388a-45ee-9a17-da6dc6e1b3fa"), Traits.Instances.Cold.ID);
            builder.Add(Guid.Parse("9403c507-a31b-4876-a1b9-4878b0ef11a6"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("7efce8a3-f665-459f-b278-27d793e224bc"), Traits.Instances.Electricity.ID);
            builder.Add(Guid.Parse("26b22023-700a-41b7-8c25-c95e7b2a55ee"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("fe1704de-9c22-4002-8732-42f36929e0b1"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("b9907073-4e57-4e76-b9b7-cae6dbc37e52"), Traits.Instances.Water.ID);
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
