using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Veil : Template
    {
        public static readonly Guid ID = Guid.Parse("68695461-f97b-4eec-a786-24c53ccbcade");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Veil",
                Level = 4,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "1 hour.",
                Targets = "Up to 10 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e992d4a8-f065-4ec0-bc76-6f60c1c07713"), Type = TextBlockType.Text, Text = "You disguise the targets as other creatures of the same body shape and roughly similar height (within 6 inches) and weight (within 50 pounds). The disguise can hide the targets’ identities or let them appear to be of another ancestry, but it’s not precise enough to impersonate specific individuals. The spell doesn’t change voice, scent, or mannerisms. You choose the disguise for each target; for example, you could make one target appear to be a dwarf and another an elf." };
            yield return new TextBlock { Id = Guid.Parse("9c216e85-c937-49e5-b62b-b4f11ebb40c0"), Type = TextBlockType.Text, Text = "Casting veil counts as setting up a disguise for the purpose of the Impersonate action. It allows the target to ignore any circumstance penalties they might take for being disguised as dissimilar creatures, and it gives the targets a +4 status bonus to Deception checks to prevent others from seeing through their disguises, and add their level even if untrained. You can Dismiss any or all of these disguises." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("4d391415-5c7c-4d93-8abb-5ba91087f97a"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ad5bb978-c10c-4882-ae66-a571d227180a"), Type = TextBlockType.Text, Text = "The spell also disguises the targets’ voices and scents; it gains the auditory and olfactory traits." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("821533e0-2046-4a4d-9a3a-055f34674807"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1afad139-5f7f-4b14-87b2-a0ce79c983d8"), Type = TextBlockType.Text, Text = "The targets can appear as any creature of the same size, even specific individuals. You must have seen an individual to reproduce their appearance. The spell also disguises the targets’ voices and scents; it gains the auditory and olfactory traits." }
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
                Id = Guid.Parse("09e04953-8098-4341-bc8b-338d44ac3f69"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
