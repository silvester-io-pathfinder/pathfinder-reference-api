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
    public class StaffOfTransmutation : Template
    {
        public static readonly Guid ID = Guid.Parse("33cfe402-9370-4a89-9bc1-c7daaa59c542");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Transmutation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("c52e913e-7408-49de-84ae-d3f812bf23a6"), "A glass orb atop this metal staff contains fine, undulating sand. While wielding the staff, you gain a +2 circumstance bonus to checks to identify transmutation magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("cbd6ab53-8f8f-47c7-b519-ef9d8544ff57"),
                Name = "Staff of Transmutation",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("d42a7309-eefe-4e1c-b2f5-a43b1272d00a"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("dd2e3c33-5db3-40ac-8ec4-0df16f538105"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("1971b09e-320b-450e-9e29-66f2fab2341f"), SpellId = Spells.Instances.Sigil.ID},
                    new StaveSpell { Id = Guid.Parse("24f6a86f-9ea3-4a72-88e6-defc3293f6ab"), Level = 1, SpellId = Spells.Instances.FleetStep.ID},
                    new StaveSpell { Id = Guid.Parse("3b9f503e-67c4-44dc-908b-f96704752580"), Level = 1, SpellId = Spells.Instances.Jump.ID},
                    new StaveSpell { Id = Guid.Parse("c6d4ef37-2b30-49c3-9eef-3fd2bbff6862"), Level = 2, SpellId = Spells.Instances.Enlarge.ID},
                    new StaveSpell { Id = Guid.Parse("5a2a8ceb-e395-407a-b6b0-1d466817b55c"), Level = 2, SpellId = Spells.Instances.HumanoidForm.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("9e686119-9fff-44fb-b7c8-6891a14fd6b6"),
                Name = "Staff of Transmutation (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("4cebc0b8-8274-4143-bb15-04b03705a49d"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f6e34c90-2d76-4ebd-a91f-0ac7943aad25"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("8bbe281c-6451-437a-859d-52c6238ba1ca"), Level = 3, SpellId = Spells.Instances.FeetToFins.ID},
                    new StaveSpell { Id = Guid.Parse("3803a2c7-56dd-4112-b9bc-8554abd33e62"), Level = 3, SpellId = Spells.Instances.Jump.ID},
                    new StaveSpell { Id = Guid.Parse("ada3ca3c-f646-4002-8804-fec37cab191e"), Level = 4, SpellId = Spells.Instances.GaseousForm.ID},
                    new StaveSpell { Id = Guid.Parse("e57c7b97-7f27-4521-ad16-ec85d10e4391"), Level = 4, SpellId = Spells.Instances.ShapeStone.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("54f951f2-6246-402f-827d-5863e8dd8bb0"),
                Name = "Staff of Transmutation (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("70fab50b-4ecf-48aa-8743-8fdcd11bc1d4"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("2142d6f3-b870-4d8e-a682-5ee2f913edce"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("265a0eb8-19a6-4554-9565-13db250116e8"), Level = 5, SpellId = Spells.Instances.HumanoidForm.ID},
                    new StaveSpell { Id = Guid.Parse("1442c96a-1a50-4b60-beea-3ef40db3d937"), Level = 6, SpellId = Spells.Instances.BalefulPolymorph.ID},
                    new StaveSpell { Id = Guid.Parse("647662e9-a18b-42bb-a1fc-06e6a9c7d82f"), Level = 6, SpellId = Spells.Instances.DragonForm.ID},
                    new StaveSpell { Id = Guid.Parse("20ca8e69-90e1-4697-a8a0-bc5c9b690d50"), Level = 6, SpellId = Spells.Instances.FleshToStone.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("e9ce07e5-3c4f-4fa9-9d65-b57758d6a937"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("8de875e7-d896-4487-8be7-d08c4824e5d8"), Traits.Instances.Staff.ID);
            builder.Add(Guid.Parse("9a055bbe-3a16-41bc-9da3-7bfbabfe02c8"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe46c6e5-cb8f-4a2a-930f-41da6fefbd8b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
