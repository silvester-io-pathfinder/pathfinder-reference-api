using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DetectMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("1e7838ee-f64d-4806-8d3d-e55ba4261c03");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Detect Magic",
                Level = 1,
                Area = "30-foot emanation",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c254ca49-adf5-438e-bf37-13157c04912d"), Type = Utilities.Text.TextBlockType.Text, Text = "You send out a pulse that registers the presence of magic. You receive no information beyond the presence or absence of magic. You can choose to ignore magic you’re fully aware of, such as the magic items and ongoing spells of you and your allies." };
            yield return new TextBlock { Id = Guid.Parse("ba775672-2c5d-43a3-a002-e1214d439f7e"), Type = Utilities.Text.TextBlockType.Text, Text = "You detect illusion magic only if that magic’s effect has a lower level than the level of your detect magic spell. However, items that have an illusion aura but aren’t deceptive in appearance (such as an invisibility potion) typically are detected normally." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c9d1c03b-32b0-4182-ad71-89f87576f5a7"),
                Level = "3rd", 
                Details =
                {
                    new TextBlock { Id = Guid.Parse("86320f63-c48b-4b85-86fc-1fe0acef448e"), Type = Utilities.Text.TextBlockType.Text, Text = "You learn the school of magic for the highestlevel effect within range that the spell detects. If multiple effects are equally strong, the GM determines which you learn." }
                }
            };

            yield return new SpellHeightening
            { 
                Id = Guid.Parse("0e4f844c-c605-4423-9321-ca5241df1950"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a1ef296a-a8d5-40bd-94cf-6d2ed7f47ebe"), Type = Utilities.Text.TextBlockType.Text, Text = "As 3rd level, but you also pinpoint the source of the highest-level magic. Like for an imprecise sense, you don’t learn the exact location, but can narrow down the source to within a 5-foot cube (or the nearest if larger than that)." }
                }
            };
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
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b17a919d-279f-491b-9ac9-31607f54459c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
