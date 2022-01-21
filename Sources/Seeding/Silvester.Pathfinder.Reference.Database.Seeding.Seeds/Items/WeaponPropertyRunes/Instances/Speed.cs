using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.WeaponPropertyRunes.Instances
{
    public class Speed : Template
    {
        public static readonly Guid ID = Guid.Parse("3ce6bdb7-e2a1-4224-bb8c-d3613973cfbe");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Speed",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c36259fc-0c5b-4a24-b5b7-a5cd41ce389d"), "Attacks with a speed weapon are supernaturally swift.");
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = Guid.Parse("c7825ff9-b173-4c02-9d7b-f0f53efc3601"),
                Name = "Speed",
                Usage = "Etched onto a weapon.",
                Level = 16,
                Price = 1000000,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Rare.ID,
				Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("4cbc3872-d879-462c-aa7a-a0afee19dd37"), "While wielding a speed weapon, you gain the quickened condition, but you can use the additional action granted only to make a Strike with the etched weapon.")
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("2c8227b8-9288-4cd7-9ecc-3d55cf007b7a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("9d5b9ec9-b8ce-420b-a36a-4e2e28da5e60"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("72f42e77-a941-43c6-9136-eaec11b7e6f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 585
            };
        }
    }
}
