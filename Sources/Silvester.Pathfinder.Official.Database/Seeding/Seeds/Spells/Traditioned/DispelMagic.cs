using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DispelMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("5d1503f3-0176-4480-93b5-c4b4fef56dd3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dispel Magic",
                Level = 2,
                Range = "120 feet.",
                Targets = "1 spell effect or unattended magic item.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("06d14c23-0dc1-457d-8c49-3fdab5484171"), Type = Utilities.Text.TextBlockType.Text, Text = "You unravel the magic behind a spell or effect. Attempt a counteract check against the target (page 458). If you successfully counteract a magic item, the item becomes a mundane item of its type for 10 minutes. This doesn’t change the item’s non-magical properties. If the target is an artifact or similar item, you automatically fail." };
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dd2ef9b-3651-4b39-91e5-ccabbee278c0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 330
            };
        }
    }
}
