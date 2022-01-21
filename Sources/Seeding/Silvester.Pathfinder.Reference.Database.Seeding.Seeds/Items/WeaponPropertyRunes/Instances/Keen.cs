using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Keen : Template
    {
        public static readonly Guid ID = Guid.Parse("06c3e60c-a8fd-4ded-9b23-23f224927ac2");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Keen",
            };
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("660df2ec-e557-4f8b-b764-68de9070e59f"),
                Name = "Keen",
                Usage = "Etched onto a piercing or slashing melee weapon.",
                Level = 13,
                Price = 300000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("2437c2d7-9210-4723-8ecd-2b926c969c00"), "The edges of a keen weapon are preternaturally sharp. Attacks with this weapon are a critical hit on a 19 on the die as long as that result is a success. This property has no effect on a 19 if the result would be a failure.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("eb67eebb-8cce-4a6f-8e13-9b6febf7fade"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("577bc1d4-6b4c-4a80-81c8-f37b3bc588b2"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6f0b6a4c-4daa-48ff-b82e-8e061658825b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 584
            };
        }
    }
}
