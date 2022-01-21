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
    public class AnimalStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("c6e92b4d-5564-4bf9-8cf8-e3d254c06786");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Animal Staff",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("8179200f-aa5a-40f0-b249-ddf1fdb170b5"), "This staff is topped with carved animal and monster heads. While wielding the staff, you gain a +2 circumstance bonus to Nature checks to identify animals.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("3b6cc049-e262-4866-be8c-0cc42c807bb0"),
                Name = "Animal Staff",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 9000,
                Level = 4,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("adae5a18-90b6-480c-aa5f-5ea2ce96d397"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("b5ff0bd9-0083-4a8d-a570-1b47420f18f1"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("b4ad8c66-fe10-4fca-8829-bd02149c8e91"), SpellId = Spells.Instances.KnowDirection.ID},
                    new StaveSpell { Id = Guid.Parse("30e5f473-2d4f-4730-b3ce-d62de389de6c"), Level = 1, SpellId = Spells.Instances.MagicFang.ID},
                    new StaveSpell { Id = Guid.Parse("f9710185-0aab-4c23-9654-d735b0f72261"), Level = 1, SpellId = Spells.Instances.SummonAnimal.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("cfcbe18d-96aa-4216-8ee7-b0cab4276945"),
                Name = "Animal Staff (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 46000,
                Level = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("11df2f73-c715-4f2f-9198-5251f35e4ead"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("15a38248-3af9-4de9-b34b-2055119cea17"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d4446c5d-3fcb-44be-ba85-e71857d4a34a"), Level = 2, SpellId = Spells.Instances.AnimalMessenger.ID},
                    new StaveSpell { Id = Guid.Parse("e1d6704a-fb64-4f04-9c80-9681ce0bd7b6"), Level = 2, SpellId = Spells.Instances.SpeakWithAnimals.ID},
                    new StaveSpell { Id = Guid.Parse("51f60983-5a9c-4409-be13-cd7ee4aca94b"), Level = 2, SpellId = Spells.Instances.SummonAnimal.ID},
                    new StaveSpell { Id = Guid.Parse("787bf10f-f2aa-43d5-a02f-bc8f942cad04"), Level = 3, SpellId = Spells.Instances.AnimalForm.ID},
                    new StaveSpell { Id = Guid.Parse("c4ddd80a-15e9-410b-bfa6-27e8c85cd3a1"), Level = 3, SpellId = Spells.Instances.SummonAnimal.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("529e9dd1-7862-4102-8942-146c19fca8fe"),
                Name = "Animal Staff (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 190000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("96735ded-4123-4c2b-978f-d76714f1cbbd"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("4261ec5a-86b8-4fb1-ae01-773b515d4877"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("5716d17f-d96c-4b4b-b3b6-518976ab3971"), Level = 4, SpellId = Spells.Instances.SummonAnimal.ID},
                    new StaveSpell { Id = Guid.Parse("036a7176-fd05-4745-ba13-34aa13503525"), Level = 5, SpellId = Spells.Instances.AnimalForm.ID},
                    new StaveSpell { Id = Guid.Parse("003e55a2-806e-4c9e-bd97-732e3386aec7"), Level = 5, SpellId = Spells.Instances.MoonFrenzy.ID},
                    new StaveSpell { Id = Guid.Parse("ba7b528e-0195-4b30-99b5-bae99892b362"), Level = 5, SpellId = Spells.Instances.SummonAnimal.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("19d4a109-98b9-48ba-878c-4886fdc5f436"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("617930d1-25a5-4bc8-8cbb-1cd9722c921a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("748d10cd-acb6-422f-8090-8c96d1c27590"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("143f042c-1425-4d70-aaa4-6205785d462a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 592
            };
        }
    }
}
