using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SanctifiedGround : Template
    {
        public static readonly Guid ID = Guid.Parse("7de9fc25-8163-4dc8-a4b2-d8dfc9105864");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sanctified Ground",
                Level = 3,
                CastTime = "1 minute.",
                Cost = "1 vial of holy water.",
                Area = "30-foot burst centered on you.",
                Duration = "24 hours.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ebcb3f9d-0dad-4e0c-ba4f-f6a2ccdbcebd"), Type = TextBlockType.Text, Text = "You sanctify the area, sprinkling it with holy water and warding it against your foes. Choose aberrations, celestials, dragons, fiends, monitors, or undead. All creatures in the area gain a +1 status bonus to AC, attack rolls, damage rolls, and saving throws against the chosen creatures." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Consecration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87745d09-9166-48dd-b905-835959480eab"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 366
            };
        }
    }
}
