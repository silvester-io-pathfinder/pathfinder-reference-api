using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UndetectableAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("2939b6ae-7c45-46a1-9904-efb55e7c7da9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Undetectable Alignment",
                Level = 2,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 creature or object.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2939b6ae-7c45-46a1-9904-efb55e7c7da9"), Type = TextBlockType.Text, Text = "You shroud a creature or object in wards that hide its alignment. The target appears to be neutral to all effects that would detect its alignment." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2939b6ae-7c45-46a1-9904-efb55e7c7da9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
