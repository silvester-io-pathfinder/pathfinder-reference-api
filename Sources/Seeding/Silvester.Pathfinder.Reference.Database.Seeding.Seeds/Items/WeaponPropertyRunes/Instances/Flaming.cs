using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Flaming : Template
    {
        public static readonly Guid ID = Guid.Parse("aa35dfd4-adc6-4890-a6aa-f9aa6b9a481c");
        public static readonly Guid STANDARD_ID = Guid.Parse("b58e2a96-37d4-4fba-88d3-6e0b7c5f343f");
        public static readonly Guid GREATER_ID = Guid.Parse("77655a2a-e1e7-4374-89e2-c54b011d95bd");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Flaming",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0d37b169-ac4c-45c4-989b-5bfa75d0123d"), "This weapon is empowered by flickering flame. The weapon deals an additional 1d6 fire damage on a successful Strike, plus 1d10 persistent fire damage on a critical hit.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Flaming",
                Usage = "Etched onto a weapon.",
                Level = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Flaming (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 15,
                Price = 650000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("0f90f3f7-66ed-43ac-bc3d-c28968b5fbec"), "Increase the persistent damage on a critical hit to 2d10. Fire damage dealt by this weapon (including the persistent fire damage) ignores the target's fire resistance.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("b954d378-2651-4a98-84f8-627719b53a5d"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("5a61e108-2677-46ce-9a5c-b930ed355146"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("cfe2bb8d-a655-4618-add5-b1aef49c3c40"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f008cc0e-bd01-44ab-a73e-95aa6e09ac04"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
