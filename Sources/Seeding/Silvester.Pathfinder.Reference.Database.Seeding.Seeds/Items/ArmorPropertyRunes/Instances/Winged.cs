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
    public class Winged : Template
    {
        public static readonly Guid ID = Guid.Parse("8adaa470-41e9-4308-bd26-d8d3188d02f4");

        protected override ArmorPropertyRune GetArmorPropertyRune()
        {
            return new ArmorPropertyRune
            {
                Id = ID,
                Name = "Winged",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("6036a2f4-03fd-44a3-9a76-ece5df9fe42a"), "This rune is a swirling glyph on the front of the armor. A large pair of transparent, ephemeral wings floats out from the back of the armor.");;
        }

        protected override IEnumerable<ArmorPropertyRuneVariant> GetArmorPropertyRuneVariants()
        {
            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("5a9122b7-a6a1-4da6-87ff-de35ec0e88ad"),
                Name = "Winged",
                Level = 13,
                Price = 250000,
                PotencyId = Potencies.Instances.Standard.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3ef6367b-9197-4c1e-bbbb-7416d61d3852"), "This effect lasts for 5 minutes or until you Dismiss it. Once the effect ends, the wings disappear completely, reappearing in their ephemeral form 1 hour later.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c3acb77d-f7f9-4724-ba3a-1a595c620e50"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("5368e5af-9926-497b-b2cf-e24945771a58"), "You trace the rune on the front of the breastplate and the armor's ephemeral wings grow tangible, granting you a fly Speed of 25 feet or your land Speed, whichever is slower. This effect lasts for 5 minutes or until you Dismiss it. Once the effect ends, the wings disappear completely, reappearing in their ephemeral form 1 hour later.");
                            });
                    })
                    .Build()
            };

            yield return new ArmorPropertyRuneVariant
            {
                Id = Guid.Parse("cfae11f9-8180-46c2-a9be-3aad48e03144"),
                Name = "Winged (Greater)",
                Level = 19,
                Price = 3500000,
                PotencyId = Potencies.Instances.Greater.ID,
				BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
					.Text(Guid.Parse("d1294e14-f2af-4f2a-9423-a01b0a86e6b0"), "Once activated, the wings remain tangible indefinitely. You can Dismiss the activation if you choose, and you don't have to wait an hour to activate the rune again.")
					.Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d54032d0-0c08-4511-8158-f4969cee061b"), ActionTypes.Instances.TwoActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command, Interact")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("c660c9a8-1b2c-4c3d-9634-7e401e88d4ba"), "You trace the rune on the front of the breastplate and the armor's ephemeral wings grow tangible, granting you a fly Speed of 25 feet or your land Speed, whichever is slower. This effect lasts indefinitely. You can Dismiss the activation if you choose.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("157608b3-9dcf-412d-bc58-10a84bce0ca6"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6d4f1cb4-27e1-42b7-8c33-f73021a9f583"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8883e2af-50af-44ad-b20e-261a8acc0f34"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 265
            };
        }
    }
}
