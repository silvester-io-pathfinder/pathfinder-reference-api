using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IllusoryObject : Template
    {
        public static readonly Guid ID = Guid.Parse("45e1514e-a300-4c68-8853-3ad4902b9a5a");

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
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92d0dffc-6cb3-4b94-916b-6bb20a8d0a4e"), Type = TextBlockType.Text, Text = "You create an illusory visual image of a stationary object. The entire image must fit within the spell’s area. The object appears to animate naturally, but it doesn’t make sounds or generate smells. For example, water would appear to pour down an illusory waterfall, but it would be silent." };
            yield return new TextBlock { Id = Guid.Parse("1d323474-d269-4551-831c-213b67e821f8"), Type = TextBlockType.Text, Text = "Any creature that touches the image or uses the Seek action to examine it can attempt to disbelieve your illusion." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3fa9139d-a19c-4235-9e7a-bf242c9a26ad"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e46c70c1-5307-4f1b-bd87-10aa53a28b80"), Type = TextBlockType.Text, Text = "Your image makes appropriate sounds, generates normal smells, and feels right to the touch. The spell gains the auditory and olfactory traits. The duration increases to 1 hour." }
                }
            };
            yield return new SpellHeightening
            {
                Id = Guid.Parse("869bb731-4868-42fb-be87-e7fb3f751530"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8cd0e665-f13d-418b-b22a-3c02e2b9c4ca"), Type = TextBlockType.Text, Text = "As the 2nd-level version, but the duration is unlimited." }
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
                Id = Guid.Parse("4c75010f-5fe0-446d-9650-b920f47c6791"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 345
            };
        }
    }
}
