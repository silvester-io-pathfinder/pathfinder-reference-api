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
    public class StaffOfEnchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("aa970d4a-5183-439c-bbf0-fbebd9bfa612");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Enchantment",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("bb2b3277-0920-4742-99e2-4bcd11ba51fa"), "A mesmerizing gemstone caps the head of this handsomely crafted wooden staff. While wielding the staff, you gain a +2 circumstance bonus to checks to identify enchantment magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("5dba5151-aabb-4bfa-a823-71546ff3f2ed"),
                Name = "Staff of Enchantment",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bb08a0e4-c7b4-4568-9e67-b494f8dc6aeb"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("9d16d224-3a30-4fac-93b9-1f6ef0f1efb3"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("c740691f-9c50-49e3-9848-d9d08a4bd108"), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse("c833c8cb-97b9-47e8-89a7-48f59ecf8468"), Level = 1, SpellId = Spells.Instances.Charm.ID},
                    new StaveSpell { Id = Guid.Parse("eb1f9031-01f0-47cb-b803-c073584d86e7"), Level = 1, SpellId = Spells.Instances.Command.ID},
                    new StaveSpell { Id = Guid.Parse("0aa57aa6-f213-47e1-a357-14bb6bb36758"), Level = 2, SpellId = Spells.Instances.HideousLaughter.ID},
                    new StaveSpell { Id = Guid.Parse("8a24577e-6ff9-4a7c-a538-33b785c3401b"), Level = 2, SpellId = Spells.Instances.TouchOfIdiocy.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("f30e27f6-c009-47f4-b777-31aa55376a7f"),
                Name = "Staff of Enchantment (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9d1e13b4-8cec-47a1-a095-a533c7ead2a3"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("36769064-c8d8-4fc8-aa92-23b9b4440d24"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("16b10aaf-d013-4f73-958f-f5834aaa5cb1"), Level = 3, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse("809940c8-978f-4816-b630-7489eca9a5cf"), Level = 4, SpellId = Spells.Instances.Charm.ID},
                    new StaveSpell { Id = Guid.Parse("a3a034bb-1abb-449e-bf1f-2b66d7fb2935"), Level = 4, SpellId = Spells.Instances.Confusion.ID},
                    new StaveSpell { Id = Guid.Parse("de53a226-3b4d-4c7e-ab63-581a5ccd46cf"), Level = 4, SpellId = Spells.Instances.Suggestion.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("d4fbabbb-f99b-45af-a164-2ebfdbd845e3"),
                Name = "Staff of Enchantment (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("57bfffbf-0044-4846-bcea-51652211dac9"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("3d03409e-22c4-4a3b-b88c-d4a8457b63ec"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("e9caf0c4-6dd7-4d81-9a79-5934612c7d12"), Level = 5, SpellId = Spells.Instances.Command.ID},
                    new StaveSpell { Id = Guid.Parse("18ba7469-7eed-41a9-b680-4619479446ee"), Level = 5, SpellId = Spells.Instances.CrushingDespair.ID},
                    new StaveSpell { Id = Guid.Parse("c70147b4-1607-4278-8db7-ebb2aa5d094a"), Level = 6, SpellId = Spells.Instances.Dominate.ID},
                    new StaveSpell { Id = Guid.Parse("4d7edaca-a6a9-4642-ab4b-835404a5c703"), Level = 6, SpellId = Spells.Instances.Feeblemind.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ded98d35-35b5-4bbd-a11d-b7ec331a0ca1"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("d2c2365f-fe27-455e-ae39-f80d055080a1"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("f888ae60-2424-4e54-a27d-297f1b74671e"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e3efcc10-d2e2-4857-ac80-0730b3cb1023"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
