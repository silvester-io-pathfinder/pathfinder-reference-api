using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Staves.Instances
{
    public class StaffOfDivination : Template
    {
        public static readonly Guid ID = Guid.Parse("c0d7e91e-f22f-45d6-b506-214bf7f32883");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Divination",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("167e1f8a-97f1-4c3c-ad9d-4ca54924adc1"), "Semiprecious gemstones emerge, seemingly at random, from the surface of this gnarled wooden staff. While wielding it, you gain a +2 circumstance bonus to checks to identify divination magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("e36b91a7-0518-45a8-b0be-dfc2c04cf7ce"),
                Name = "Staff of Divination",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8417f29c-8663-4e1c-af71-99cc642adba3"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("2df9eb6c-2c33-475a-a00a-289d58d39917"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("de8e4156-0d1d-4c8f-b555-c00646a5971f"), SpellId = Spells.Instances.DetectMagic.ID},
                    new StaveSpell { Id = Guid.Parse("518a4c4c-bed5-45dc-b27f-049f7d86dbf9"), Level = 1, SpellId = Spells.Instances.TrueStrike.ID},
                    new StaveSpell { Id = Guid.Parse("42c9d55b-0852-4f19-a737-d5e638709d2a"), Level = 2, SpellId = Spells.Instances.ComprehendLanguage.ID},
                    new StaveSpell { Id = Guid.Parse("268ff172-d0df-414f-92c2-7c77203e12a0"), Level = 2, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("3f73e9cc-bd49-47a1-b6ac-bbab38236217"), Level = 2, SpellId = Spells.Instances.SeeInvisibility.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("f0329a30-d0b7-440f-a491-933ef1124bfc"),
                Name = "Staff of Divination (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f04bf66e-b856-4751-93bc-0fbb13443e1c"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c8532a8a-dbdf-41db-8f00-6a63c47a9608"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("9de8c700-da38-4468-92ec-025dabe32c83"), Level = 3, SpellId = Spells.Instances.Clairaudience.ID},
                    new StaveSpell { Id = Guid.Parse("b482daed-ce90-4d38-a78a-12b0c0980c03"), Level = 3, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("3e0ecc0b-0d4f-42db-831f-f6fd1d1ee67a"), Level = 4, SpellId = Spells.Instances.Clairvoyance.ID},
                    new StaveSpell { Id = Guid.Parse("7a7569eb-7df9-4f30-be4d-064a3d1f9d72"), Level = 4, SpellId = Spells.Instances.ComprehendLanguage.ID},
                    new StaveSpell { Id = Guid.Parse("74889b33-9658-4fde-8c28-34bfa7cc2662"), Level = 4, SpellId = Spells.Instances.Telepathy.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("31a7723f-78a8-4f7f-999a-b3a240be2161"),
                Name = "Staff of Divination (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5163c97a-5e72-417c-b626-e80cfe2a89ba"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8a2d9f41-cbde-4e43-9368-b08e6cb1ce52"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("78c923eb-c8e7-42e0-8037-f45560a6ce2d"), Level = 5, SpellId = Spells.Instances.PryingEye.ID},
                    new StaveSpell { Id = Guid.Parse("63c47cc6-eb08-41a7-95ce-f9bf3921a65f"), Level = 5, SpellId = Spells.Instances.Sending.ID},
                    new StaveSpell { Id = Guid.Parse("6c64aaaf-2d04-4bfd-9074-7243559ad07c"), Level = 6, SpellId = Spells.Instances.Telepathy.ID},
                    new StaveSpell { Id = Guid.Parse("91c37ac3-1a86-4fca-9fb7-25ce39a740c4"), Level = 6, SpellId = Spells.Instances.TrueSeeing.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0cbd3c05-c413-4013-a452-10bc3a85df9a"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("ee3130ad-f16d-4ebe-bc22-0e6aa684f442"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("9b363b57-13be-4770-bea8-7df1323e5b81"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41481c97-3ccf-4a35-82a8-ca4d25291d55"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
