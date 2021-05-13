using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BindUndeadSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("b59d7490-542e-4d17-9463-2e384faf2c0f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Bind Undead",
                Level = 3,
                Range = 30,
                Duration = "1 day.",
                Targets = "1 mindless undead creature with a level no greater than bind undead's spell level.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba4fb28f-c544-4e92-9c3c-540e371b0754"), Type = Utilities.Text.TextBlockType.Text, Text = "With a word of necromantic power, you seize control of the target. It gains the minion trait. If you or an ally uses any hostile actions against the target, the spell ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }
    }
}
