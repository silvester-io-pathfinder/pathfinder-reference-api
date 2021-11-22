using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MudPit : Template
    {
        public static readonly Guid ID = Guid.Parse("f2c8bf6b-a3d6-49d0-b5ef-dfe5fa47ada7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mud Pit",
                Level = 1,
                Range = "60 feet.",
                Duration = "1 minute.",
                Area = "Squares on the gound in a 15-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b9918c0-a438-4e7e-b492-e89943367c61"), Type = TextBlockType.Text, Text = "Thick, clinging mud covers the ground, 1 foot deep. The mud is difficult terrain." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71ca4ccb-2af8-4a27-9fa9-8c320668a376"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 117
            };
        }
    }
}
