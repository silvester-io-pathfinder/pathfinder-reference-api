using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.ArmorPropertyRunes.Instances
{
    public class SinisterKnightRune : Template
    {
        public static readonly Guid ID = Guid.Parse("a134a0b4-5255-41c8-8a0d-179e943a4ef4");

        protected override ArmorPropertyRune GetRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Sinister Knight",
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("778a70f9-da88-4674-aa15-250c3d5da5c2"), Type = TextBlockType.Text, Text = "Sinister knight armor shrouds the wearer’s identity in secrecy, allowing Crimson Reclaimers to pass among foes without being immediately unmasked." };
            yield return new TextBlock { Id = Guid.Parse("429f0b0a-7865-4ed3-8236-0ad1c5e4f673"), Type = TextBlockType.Text, Text = "The wearer can Dismiss the disguise, and if the wearer’s armor is removed, the disguise deactivates automatically." };
        }

        protected override IEnumerable<ArmorPropertyRunePotencyBinding> GetPotencies()
        {
            yield return new ArmorPropertyRunePotencyBinding
            {
                Id = Guid.Parse("3ad67194-61a8-4507-836e-3207ed5793dc"),
                Benefits = "The wearer gains a +1 item bonus to Deception checks.",
                ItemLevel = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Unclassified.ID,
            };
        }

        protected override ArmorPropertyRuneAction? GetAction()
        {
            return new ArmorPropertyRuneAction
            {
                Id = Guid.Parse("f5538309-abd0-4e0d-9464-4ef93a0de3ff"),
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Name = "Envision",
                Effect = "With a thought, the wearer activates a disguise. While the sinister knight armor’s disguise is active, any identifying insignia or aesthetic of the armor is replaced by generic malevolent aesthetics such as spikes or demonic faces. While in the disguise, the wearer is always considered to be taking precautions against lifesense, and even a creature that successfully notices the wearer with its lifesense mistakes the wearer for an undead unless it critically succeeds at its Perception check or the wearer critically fails a Deception or Stealth check. Finally, while in the disguise, the rune attempts to counteract any effects that would reveal your alignment; on a successful counteract check, rather than negate the effect, the rune causes the effect to perceive your alignment as evil (maintaining any lawful or chaotic component of your alignment).",
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Uncommon.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f972be2-cbf4-4985-ac07-f0f487c4d984"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 92
            };
        }

    }
}
