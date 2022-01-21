using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Returning : Template
    {
        public static readonly Guid ID = Guid.Parse("89332a34-0067-4b4f-b5a8-ce00c41c6935");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Returning",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("75f92632-1173-4d98-8546-7d8e023ce6e0"),
                Name = "Returning",
                Usage = "Etched on a thrown weapon.",
                Level = 3,
                Price = 5500,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("14bb656e-55be-4111-aa46-a37ddf6df5db"), "When you make a thrown Strike with this weapon, it flies back to your hand after the Strike is complete. If your hands are full when the weapon returns, it falls to the ground in your space.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("49608865-f1bd-4314-8421-d1a1cc53a4c3"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("56e72b12-4cb2-4c57-a74a-37ac97508e71"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3da8b5c-3de7-416a-aea4-91db6e328f7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
