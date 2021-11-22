using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FaerieFire : Template
    {
        public static readonly Guid ID = Guid.Parse("e43cda60-97f0-4147-8b5d-948251706bc4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Faerie Fire",
                Level = 2,
                Range = "120 feet.",
                Area = "10-foot burst.",
                Duration = "5 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("794778ac-97d6-4031-940d-9b576265d5a4"), Type = TextBlockType.Text, Text = "All creatures in the area when you cast the spell are limned in colorful, heatless fire of a color of your choice for the duration. Visible creatures can't be concealed while affected by faerie fire. If the creatures are invisible, they are concealed while affected by faerie fire, rather than being undetected." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Light.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c520a010-40a9-4b70-8960-d35e2a3bb16d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
