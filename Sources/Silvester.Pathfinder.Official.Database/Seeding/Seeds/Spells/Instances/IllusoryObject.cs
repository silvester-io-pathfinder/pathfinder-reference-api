using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class IllusoryObject : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Illusory Object",
                Level = 1,
                Range = "500 feet.",
                Area = "20-foot burst.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You create an illusory visual image of a stationary object. The entire image must fit within the spell’s area. The object appears to animate naturally, but it doesn’t make sounds or generate smells. For example, water would appear to pour down an illusory waterfall, but it would be silent." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Any creature that touches the image or uses the Seek action to examine it can attempt to disbelieve your illusion." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your image makes appropriate sounds, generates normal smells, and feels right to the touch. The spell gains the auditory and olfactory traits. The duration increases to 1 hour." }
                }
            };
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As the 2nd-level version, but the duration is unlimited." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 345
            };
        }
    }
}
