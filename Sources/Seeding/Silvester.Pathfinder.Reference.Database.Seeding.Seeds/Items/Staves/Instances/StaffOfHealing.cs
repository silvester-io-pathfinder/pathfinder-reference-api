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
    public class StaffOfHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("7df574ec-0a8a-40f1-9ff0-d43b341ce224");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Healing",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("f325d179-14a1-447d-b9ee-5e624663d58a"), "Made of smooth, white wood, this staff is capped at each end with a golden cross adorned with a multitude of ruby cabochons. A staff of healing grants an item bonus to the Hit Points you restore anytime you cast the heal spell using your own spell slots or using charges from the staff.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("1ac0e3dc-9dcc-4723-b954-4cfa99b3bbcd"),
                Name = "Staff of Healing",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 9000,
                Level = 4,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d612c290-5288-40ad-9718-eeea27672eff"), "The item bonus granted to heal spells is +1.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a0436144-5a9c-45f2-9930-0c1c2c42761b"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("0bb90cc5-ca1f-4f48-9e10-989049e35074"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("13f37dc3-6fec-488c-af4c-1ed7d1360498"), SpellId = Spells.Instances.Stabilize.ID},
                    new StaveSpell { Id = Guid.Parse("131b0d8e-4d69-4de6-bab9-c3a8e9238e9a"), Level = 1, SpellId = Spells.Instances.Heal.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("332121c2-dcb3-4efa-8350-5e3eea755e1e"),
                Name = "Staff of Healing (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 47000,
                Level = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("a5c0008b-93d4-4c6b-a624-56c6556f6091"), "The item bonus granted to heal spells is +2.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("60037308-b900-4f36-8dfc-191a27567335"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("b0e434b6-58a7-4a0c-8f8a-708ea394e6f9"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3559f8ed-e535-499b-ac57-9b1f47c4b273"), Level = 2, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("951caeaa-e0f2-4d0a-ab2f-f578f4eceee4"), Level = 2, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("99816a5e-485d-44f4-ac77-7a22a9c5cb59"), Level = 2, SpellId = Spells.Instances.RestoreSenses.ID},
                    new StaveSpell { Id = Guid.Parse("4fe2862e-4e78-4924-ae25-c7b449b29601"), Level = 3, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("bf3d09b6-4349-43d2-89cd-640d9d9aff75"), Level = 3, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("64bdd93e-bdf7-41ba-a4c1-ce3831baec7f"),
                Name = "Staff of Healing (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 180000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("77a962b3-8322-47f6-8e1e-8d8f41c80c00"), "The item bonus granted to heal spells is +3.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("1fe92e9c-a042-4c95-aac3-9e5856b3d41f"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("d9a7c563-a3ee-41de-8018-110debc8f84c"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d21a467b-7cd0-46ca-a3ed-a5669216ed10"), Level = 4, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("11980430-90b0-4da5-9224-bd41828c3547"), Level = 4, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("171fac58-c769-44c6-b088-9f55008f9b4f"), Level = 5, SpellId = Spells.Instances.BreathOfLife.ID},
                    new StaveSpell { Id = Guid.Parse("f02fa874-f53f-442b-8a3e-fde8d68e32d8"), Level = 5, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("e58ec502-8f99-45eb-858d-c4a8a831fc40"), Level = 5, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("33bcd18f-66d4-4860-96b4-f8aec0bfb341"),
                Name = "Staff of Healing (True)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 920000,
                Level = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("009f8335-600b-4012-917d-e66b5696efa2"), "The item bonus granted to heal spells is +4.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("0ec53de3-666b-478b-8148-7a0a1c07cb4b"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("743ea5fb-bb29-4ff4-8dfc-0a9b14d52290"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7fc174c2-9fb1-4465-bb03-b698470eee2a"), Level = 6, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("3af8fd04-ef66-4880-88de-05c66da6a9a2"), Level = 6, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("26a1ad2b-2186-4d03-b6ee-5a7a762f5af4"), Level = 6, SpellId = Spells.Instances.RestoreSenses.ID},
                    new StaveSpell { Id = Guid.Parse("c8029e82-ebdd-41af-ade7-c7d1d14afca1"), Level = 7, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("2bd402ec-d656-4775-9ad4-7b4f27e119bd"), Level = 7, SpellId = Spells.Instances.Regenerate.ID},
                    new StaveSpell { Id = Guid.Parse("cff84142-9e9f-4701-9a87-b2d8ab44cfef"), Level = 7, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ac8e612b-0d96-4bc2-8726-749c9982fefe"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("3ef7420f-c3f3-4f19-a207-c988d2d23f13"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("1b1a9d4c-f36e-453c-bfd1-7acff97a35e6"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddaf3b83-2f7b-4757-b9f1-e29b91726dc3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
