using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ObscuringMist : Template
    {
        public static readonly Guid ID = Guid.Parse("9844abe7-e51e-4b8c-877d-1dbdb41801f3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Obscuring Mist",
                Level = 2,
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
            yield return new TextBlock { Id = Guid.Parse("5ae2b71d-f9da-443b-9429-8a00403f5ab9"), Type = TextBlockType.Text, Text = "You call forth a cloud of mist. All creatures within the mist become concealed, and all creatures outside the mist become concealed to creatures within it. You can Dismiss the cloud." };
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
            yield return Traits.Instances.Water.ID;
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8050d67-5f1d-4541-90e4-65f05c8c7679"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 355
            };
        }
    }
}
