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
    public class Invisibility : Template
    {
        public static readonly Guid ID = Guid.Parse("a33f6f32-1aa6-4d14-a352-4ef60956d7d0");

        public static readonly Guid STANDARD_ID = Guid.Parse("f3b0b720-b5f8-47af-8d61-ab0ac61eb3f7");
        public static readonly Guid GREATER_ID = Guid.Parse("223467d2-6082-4c7d-9081-dfa4080ab3df");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Invisibility",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bc6af7f1-4d9c-4333-948b-c1fbf8fef334"), "Light seems to partially penetrate this armor.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Invisibility",
                Usage = "Etched onto light armor.",
                Level = 8,
                Price = 50000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("b4b419cc-2610-4cb9-9439-0317b5010e68"), "You can activate the armor once per day.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("af444fe7-d999-43b8-8df4-25ccf53174a6"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Once per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("5277dd38-59fe-4b27-8969-50fdf83a40f6"), "Whispering the command word, you become invisible for 1 minute, gaining the effects of a 2nd-level invisibility spell.");
                            });
                    })
                    .Build()
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Invisibility (Greater)",
                Usage = "Etched onto light armor.",
                Level = 10,
                Price = 100000,
                PotencyId = Potencies.Instances.Greater.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d2c0b300-0a7a-4c86-8281-d0c4ca726325"), "You can activate the armor up to three times per day.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b3db70c4-79a4-4919-ae9d-e460d311d31d"), ActionTypes.Instances.OneAction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Frequency("Three times per day.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("31006511-e76d-457b-854e-ce17a95592a9"), "Whispering the command word, you become invisible for 1 minute, gaining the effects of a 2nd-level invisibility spell.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7767eef4-448e-49cd-a6a3-a66e23f27ecb"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("717e8a52-49b8-48ae-bcdc-160ec8400eca"), Traits.Instances.Illusion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa3b80f7-0a69-4b1d-ab02-ab4cfc0a04e9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 583
            };
        }

    }
}
