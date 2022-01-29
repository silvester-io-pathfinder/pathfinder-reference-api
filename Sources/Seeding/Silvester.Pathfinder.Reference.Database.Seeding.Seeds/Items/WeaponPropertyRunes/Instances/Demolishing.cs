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
    public class Demolishing : Template
    {
        public static readonly Guid ID = Guid.Parse("f368999f-3e4c-4f58-a335-c34c9e2a04a8");

        public static readonly Guid STANDARD_ID = Guid.Parse("ebec3d32-7eac-4538-b510-bf110c1a536c");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Demolishing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("9a828c15-cce7-4c25-868d-621189001604"), "A demolishing weapon is made to destory constructs. Damage inflicted on a construct with a demolishing weapon continues to spread throughout the creature - cracks form, linkages fail, surfaces erode - and otherwise dismantle its body. When you damage a construct using a demolishing weapon, you deal an extra 1d6 persistent force damage. On a critical hit, you deal an extra 1d12 persistent force damage instead.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Demolishing",
                Usage = "Etched onto a weapon.",
                Level = 6,
                Price = 22500,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("51c8e58c-7edf-4df5-89a3-3f08cdf7f593"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("d0c37e29-2f38-4446-9b25-c6815e5a5455"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("7e94c48c-4d5b-4cb2-babb-f0432511757e"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47f22236-66df-47c3-9fde-9b25329aa315"),
                SourceId = Sources.Instances.PathfinderSpecialFumbus.ID,
                Page = 0
            };
        }
    }
}
