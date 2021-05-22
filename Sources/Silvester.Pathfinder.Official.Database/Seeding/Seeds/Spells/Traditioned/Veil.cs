using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Veil : Template
    {
        public static readonly Guid ID = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16");

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
            yield return new TextBlock { Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"), Type = TextBlockType.Text, Text = "You disguise the targets as other creatures of the same body shape and roughly similar height (within 6 inches) and weight (within 50 pounds). The disguise can hide the targets’ identities or let them appear to be of another ancestry, but it’s not precise enough to impersonate specific individuals. The spell doesn’t change voice, scent, or mannerisms. You choose the disguise for each target; for example, you could make one target appear to be a dwarf and another an elf." };
            yield return new TextBlock { Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"), Type = TextBlockType.Text, Text = "Casting veil counts as setting up a disguise for the purpose of the Impersonate action. It allows the target to ignore any circumstance penalties they might take for being disguised as dissimilar creatures, and it gives the targets a +4 status bonus to Deception checks to prevent others from seeing through their disguises, and add their level even if untrained. You can Dismiss any or all of these disguises." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"), Type = TextBlockType.Text, Text = "The spell also disguises the targets’ voices and scents; it gains the auditory and olfactory traits." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"), Type = TextBlockType.Text, Text = "The targets can appear as any creature of the same size, even specific individuals. You must have seen an individual to reproduce their appearance. The spell also disguises the targets’ voices and scents; it gains the auditory and olfactory traits." }
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
                Id = Guid.Parse("cb02e768-e210-45b0-9ebe-fa905d605c16"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
