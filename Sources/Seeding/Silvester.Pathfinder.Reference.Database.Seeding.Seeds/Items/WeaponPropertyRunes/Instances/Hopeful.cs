using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Hopeful : Template
    {
        public static readonly Guid ID = Guid.Parse("15f1067a-1dfb-4cef-803b-6d3100a0c822");

        public static readonly Guid STANDARD_ID = Guid.Parse("9aec8b7d-8e11-4956-bda2-9c47c2c39c60");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Hopeful",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6263f593-9139-4bbc-96fc-e0f3b7c580a9"), "A weapon with a hopeful rune exudes positivity. On a critical hit with this weapon, you inspire your comrades, pushing them to fight harder and stand for your shared convictions. Allies within 30 feet that share at least one alignment component with you gain a +1 status bonus to attack rolls until the end of your next turn.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Hopeful",
                Usage = "Etched onto a weapon.",
                Level = 11,
                Price = 120000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("f150267b-1f57-41fc-b1d2-9cf4c6fc1baa"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("54826a2a-4375-41b8-8e7a-2ead2e1e073c"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18a48d2e-b120-40f1-9880-b882f0443523"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 84
            };
        }
    }
}
