using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class IllusoryDisguise : Template
    {
        public static readonly Guid ID = Guid.Parse("c781e61a-fb77-4a64-9b4c-88dd8c740f93");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Illusory Disguise",
                Level = 1,
                IsDismissable = true,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("42f8392e-8533-4b32-82ad-f22347c82f94"), Type = TextBlockType.Text, Text = "You create an illusion that causes you to appear as another creature of the same body shape, and with roughly similar height (within 6 inches) and weight (within 50 pounds), as yourself. The disguise is typically good enough to hide your identity, but not to impersonate a specific individual. The spell doesn’t change your voice, scent, or mannerisms. You can change the appearance of your clothing and worn items, such as making your armor look like a dress. Held items are unaffected, and any worn item you remove returns to its true appearance." };
            yield return new TextBlock { Id = Guid.Parse("52d6978a-5855-4cb5-8171-a9985acd5558"), Type = TextBlockType.Text, Text = "Casting illusory disguise counts as setting up a disguise for the Impersonate use of Deception; it ignores any circumstance penalties you might take for disguising yourself as a dissimilar creature, it gives you a +4 status bonus to Deception checks to prevent others from seeing through your disguise, and you add your level even if you’re untrained. You can Dismiss this spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("15f25d1c-8ef1-442f-9c38-1060b42ee736"),
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e56f234b-ebd8-4f3a-986c-d974d73d9eed"), Type = TextBlockType.Text, Text = "The spell also disguises your voice and scent, and it gains the auditory and olfactory traits." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e29e8d03-1a45-40ae-8981-4052a954d4b8"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9e3988e9-11b0-439b-a04c-b4dea9c04717"), Type = TextBlockType.Text, Text = "You can appear as any creature of the same size, even a specific individual. You must have seen an individual to take on their appearance. The spell also disguises your voice and scent, and it gains the auditory trait." }
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
                Id = Guid.Parse("88c26810-a308-4b9f-bf4b-bcc2765216d4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 345
            };
        }
    }
}
