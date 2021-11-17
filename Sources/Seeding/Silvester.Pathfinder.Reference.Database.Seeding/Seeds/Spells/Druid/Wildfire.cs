using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Wildfire : Template
    {
        public static readonly Guid ID = Guid.Parse("3f8b4c4d-82a5-4f1e-ace0-4bece1cea182");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wildfire",
                Level = 1,
                Range = "30 feet.",
                Area = "10-foot burst.",
                Duration = "Sustained up to 1 minute.",
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("87a29bc6-8ccc-4d06-b47e-03c9b08f06f6"), Type = TextBlockType.Text, Text = "A thin layer of ash and flame covers the ground in the area. The area becomes hazardous terrain. A creature that moves on the ground through the area takes 1 fire damage for every square of that area it moves into. A creature that ends its turn in the area must succeed at a Reflex save or take 1 persistent fire damage." };
            yield return new TextBlock { Id = Guid.Parse("e69d7b24-a04e-4bd9-801d-0dad00eea484"), Type = TextBlockType.Text, Text = "Each time you sustain this spell, the radius of the burst increases by 5 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a01802af-54b6-4aa4-81ea-435223dc25a6"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f533dbe2-fe83-4281-8a2f-ecae52e61c1d"), Type = TextBlockType.Text, Text = "Increase the damage and persistent damage by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa8dbd53-5fd9-4dda-8c02-aa1252e850cb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 201
            };
        }
    }
}
