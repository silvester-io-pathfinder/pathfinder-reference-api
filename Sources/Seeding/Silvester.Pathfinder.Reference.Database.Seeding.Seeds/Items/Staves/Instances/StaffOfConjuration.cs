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
    public class StaffOfConjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("0bda6552-d25a-4dc2-9b4b-8e26e2a34bdd");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Conjuration",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("fbc2eace-cdf2-4435-8eee-9b5df9ef751f"), "This ash staff is decorated with animals; wielding it, you gain a +2 circumstance bonus to checks to identify conjuration magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("e5f4e586-e8d7-4666-ae9a-b77574163d41"),
                Name = "Staff of Conjuration",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("e4084ab4-4760-494d-98cf-acc82412775b"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("6bcedc4a-ef9e-41cb-b760-3fcd116b7e76"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("1b2659d3-650e-43d0-bde6-a5c77f6c0b42"), SpellId = Spells.Instances.Tanglefoot.ID},
                    new StaveSpell { Id = Guid.Parse("6c5d1f31-7031-4cd2-aceb-f152f45ecda7"), Level = 1, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("38a34d82-d63b-44f6-9340-1d3059818cba"), Level = 1, SpellId = Spells.Instances.UnseenServant.ID},
                    new StaveSpell { Id = Guid.Parse("dae6772e-da92-4af2-816a-d7280f0257c2"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                    new StaveSpell { Id = Guid.Parse("e2d91c83-99e7-4307-b1b4-99f1964e9f98"), Level = 2, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("492c9c38-fc0b-4b1a-b650-0e13bc055c0d"), Level = 2, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("578b7372-a511-49da-9889-c75220177e59"), Level = 2, SpellId = Spells.Instances.SummonElemental.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("e092a7eb-7a53-434f-91ea-e946bb6b2cc2"),
                Name = "Staff of Conjuration (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("775de76d-72e1-4f38-ab63-69d727894552"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("5027f857-c5fa-43a2-ac00-9cdcb9eeacd3"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3e40a8a4-6355-4d97-be63-192e75eabe4d"), Level = 3, SpellId = Spells.Instances.StinkingCloud.ID},
                    new StaveSpell { Id = Guid.Parse("46dc9c73-356e-4eca-85b8-b9d3e8bd7884"), Level = 3, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0105e674-d521-4b18-83f7-904be217b0ab"), Level = 3, SpellId = Spells.Instances.SummonElemental.ID},
                    new StaveSpell { Id = Guid.Parse("69db1b49-77e8-4006-b275-2da6d3c0c379"), Level = 4, SpellId = Spells.Instances.Creation.ID},
                    new StaveSpell { Id = Guid.Parse("71eb28c9-0d98-4aec-ab18-d62693ffbdee"), Level = 4, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("b5ab4f6a-c688-4b9d-8e2c-06fc5994fa58"), Level = 4, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("6e8d5860-74a7-4851-8f1c-e5fc04142fba"), Level = 4, SpellId = Spells.Instances.SummonElemental.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("014fb783-3187-4b05-b688-8e6850699197"),
                Name = "Staff of Conjuration (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bfb0e9d7-c5b8-4c1b-adfe-8387e9d7addd"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("246cd0bc-99be-4ce0-aec6-ae9b4c93c0b1"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("f2dfdfaf-ec60-47d5-98f3-c7356ad1c609"), Level = 5, SpellId = Spells.Instances.BlackTentacles.ID},
                    new StaveSpell { Id = Guid.Parse("a7fdf95c-c555-4d0c-975e-30678e7d1882"), Level = 5, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("35385702-7fa8-4d86-bd6b-4160edc634be"), Level = 5, SpellId = Spells.Instances.SummonElemental.ID},
                    new StaveSpell { Id = Guid.Parse("392e6290-4a1c-49ea-8c93-ad90ca6f7e7f"), Level = 6, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("f3648514-9109-4c81-8b12-649b556f4228"), Level = 6, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("4e26a0c0-6ece-47bc-86a8-374ee8b0a581"), Level = 6, SpellId = Spells.Instances.SummonElemental.ID},
                }
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("abfbb194-927e-4681-ba80-8c52a84cffba"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("0c015e6c-af68-4a99-8b1a-bf0b0991e3fe"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("1b5fb45c-b5da-4f07-8b48-359f212bd995"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21886b3d-a4e8-4a79-8eec-169d60936079"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
