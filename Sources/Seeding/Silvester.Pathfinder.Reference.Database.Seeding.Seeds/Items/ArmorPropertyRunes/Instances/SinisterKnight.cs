using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.ArmorPropertyRunes.Instances
{
    public class SinisterKnight : Template
    {
        public static readonly Guid ID = Guid.Parse("a134a0b4-5255-41c8-8a0d-179e943a4ef4");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Sinister Knight",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("778a70f9-da88-4674-aa15-250c3d5da5c2"), "Sinister knight armor shrouds the wearer's identity in secrecy, allowing Crimson Reclaimers to pass among foes without being immediately unmasked.");;
            builder.Text(Guid.Parse("429f0b0a-7865-4ed3-8236-0ad1c5e4f673"), "The wearer can Dismiss the disguise, and if the wearer's armor is removed, the disguise deactivates automatically.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("3ad67194-61a8-4507-836e-3207ed5793dc"),
                Name = "Sinister Knight",
                Usage = "Etched onto heavy armor.",
                Level = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("3778dbcf-0754-4557-a037-9726b48d6a83"), "The wearer gains a +1 item bonus to Deception checks.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f5538309-abd0-4e0d-9464-4ef93a0de3ff"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Envision")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("896fc940-5f1e-4343-836c-90343ed7bde1"), "With a thought, the wearer activates a disguise. While the sinister knight armor's disguise is active, any identifying insignia or aesthetic of the armor is replaced by generic malevolent aesthetics such as spikes or demonic faces. While in the disguise, the wearer is always considered to be taking precautions against lifesense, and even a creature that successfully notices the wearer with its lifesense mistakes the wearer for an undead unless it critically succeeds at its Perception check or the wearer critically fails a Deception or Stealth check. Finally, while in the disguise, the rune attempts to counteract any effects that would reveal your alignment; on a successful counteract check, rather than negate the effect, the rune causes the effect to perceive your alignment as evil (maintaining any lawful or chaotic component of your alignment).");
                                effect.Text(Guid.Parse("d306994d-43d0-4650-8f30-ecac23739f34"), "The wearer can Dismiss the disguise, and if the wearer's armor is removed, the disguise deactivates automatically.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0caea58d-ee72-4cb6-968c-1f0d66bfda18"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3a8640b9-3acc-4dad-aff2-5a184f039a3e"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("b9b0adb1-744a-41e1-9eeb-a6cb18b90285"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("13f4c22c-05b1-4cb1-853b-ffc4034ae86c"), Traits.Instances.Uncommon.ID);
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
