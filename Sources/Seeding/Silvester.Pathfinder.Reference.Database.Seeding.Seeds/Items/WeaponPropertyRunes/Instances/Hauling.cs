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
    public class Hauling : Template
    {
        public static readonly Guid ID = Guid.Parse("cdb426e4-97f6-427b-ac92-29d351c054d5");

        public static readonly Guid STANDARD_ID = Guid.Parse("bde356da-99ba-4ef4-b0be-0a56d1dfe6c5");
        public static readonly Guid GREATER_ID = Guid.Parse("9506d5f8-5a26-4a80-bd22-79f92054312a");

        protected override WeaponPropertyRune GetWeaponPropertyRune()
        {
            return new WeaponPropertyRune
            {
                Id = ID,
                Name = "Hauling",
            };
        }

        protected override void GetInlineActions(IInlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("e7038cd2-aac7-4d85-8b1e-cecd3a1c5b7a"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
            {
                action
                    .Kind("Command")
                    .Trigger("You succeed at an attack roll to Strike with a weapon with the hauling rune.")
                    .Frequency("Once per hour.")
                    .Details(effect =>
                    {
                        effect.Text(Guid.Parse("8f96b2fe-d4ea-4e11-939b-4537c46ba7ff"), "The target must succeed at a DC 20 Reflex save or be moved 5 feet in a direction you choose. This is forced movement.");
                    });
            });
        }

        protected override IEnumerable<WeaponPropertyRuneVariant> GetWeaponPropertyRuneVariants()
        {
            yield return new WeaponPropertyRuneVariant
            {
                Id = STANDARD_ID,
                Name = "Hauling",
                Usage = "Etched onto a weapon.",
                Level = 6,
                Price = 22500,
                PotencyId = Potencies.Instances.Standard.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6af49478-0171-4690-aae0-49e87a9c6d94"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You succeed at an attack roll to Strike with a weapon with the hauling rune.")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("134b5222-d9ae-4ef9-88a5-ee281a22a7ba"), "The target must succeed at a DC 20 Reflex save or be moved 5 feet in a direction you choose. This is forced movement.");
                            });
                    })
                    .Build()
            };

            yield return new WeaponPropertyRuneVariant
            {
                Id = GREATER_ID,
                Name = "Hauling (Greater)",
                Usage = "Etched onto a weapon.",
                Level = 11,
                Price = 130000,
                PotencyId = Potencies.Instances.Greater.ID,
                BulkId = Bulks.Instances.NegligibleBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("96e7ab4d-f932-4cfd-bc7a-f0e080977062"), "The DC is 28, and the target is moved up to 10 feet.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("17306407-7c73-4342-969d-b1b43c465b64"), ActionTypes.Instances.Reaction.ID, "Activate", action =>
                    {
                        action
                            .Kind("Command")
                            .Trigger("You succeed at an attack roll to Strike with a weapon with the hauling rune.")
                            .Frequency("Once per hour.")
                            .Details(effect =>
                            {
                                effect.Text(Guid.Parse("08d11df0-5a1f-4fd3-b0ed-a1b4f04f21dd"), "The target must succeed at a DC 28 Reflex save or be moved 10 feet in a direction you choose. This is forced movement.");
                            });
                    })
                    .Build()
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("02673f93-bbef-4768-a936-444101e5ac37"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("0c87b083-9c8c-418e-ba3a-52ce8b10bdbb"), Traits.Instances.Magical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("054bdec6-ec0c-4801-bb0c-19fe7c35885d"),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 80
            };
        }
    }
}
