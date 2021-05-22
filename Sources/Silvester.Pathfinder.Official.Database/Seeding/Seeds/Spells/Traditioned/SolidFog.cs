using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SolidFog : Template
    {
        public static readonly Guid ID = Guid.Parse("8b91ccee-e2ad-45dc-9865-ea17b1623142");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Solid Fog",
                Level = 4,
                Range = "120 feet.",
                Area = "20-foot burst.",
                IsDismissable = true,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35c406a7-7da2-45e4-84d9-64ee6c9c9278"), Type = TextBlockType.Text, Text = "You conjure a bank of fog so thick it impedes movement as well as sight. This functions as obscuring mist (page 355), except that the area is also difficult terrain. You can Dismiss the spell." };
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
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4dacf13-c66a-4358-a45c-034628887014"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
