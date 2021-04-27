using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BlurSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("4f77cd26-f3f0-4e6a-8424-b01480daadc4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blur",
                Level = 2,
                Duration = "1 minute.",
                Range = 0,
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de383eb7-ec7f-460b-8b53-87dafd843c6e"), Type = Utilities.Text.TextBlockType.Text, Text = "The target’s form appears blurry. It becomes concealed. As the nature of this effect still leaves the target’s location obvious, the target can’t use this concealment to Hide or Sneak." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }
    }
}
