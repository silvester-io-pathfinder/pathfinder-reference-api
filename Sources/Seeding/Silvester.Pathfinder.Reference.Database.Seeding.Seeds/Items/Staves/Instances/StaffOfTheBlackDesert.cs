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
    public class StaffOfTheBlackDesert : Template
    {
        public static readonly Guid ID = Guid.Parse("1784527f-e3d8-4cfc-a3fd-9f15222ae211");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of the Black Desert",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cf003da9-73d4-4a5d-a143-0b141793d64f"), "his rough metal staff is pitted and sandblasted, with thousands of nigh-imperceptible sand crystals embedded in its surface. While carrying the staff, you gain a +2 circumstance bonus to Occultism checks to identify aberrations and oozes native to the Darklands.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("44596169-1982-4729-b441-22bda806c8e4"),
                Name = "Staff of the Black Desert",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 185000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("8561e922-b436-444f-99f8-845ca22f8931"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("fb00e96b-326c-4924-b167-ce38bffbebd1"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("ed31e14d-ddb4-4245-b318-626a7763b485"), SpellId = Spells.Instances.KnowDirection.ID},
                    new StaveSpell { Id = Guid.Parse("2debab00-5668-4d03-857f-6bbd38bf9b11"), Level = 1, SpellId = Spells.Instances.CreateWater.ID},
                    new StaveSpell { Id = Guid.Parse("387b7f86-298a-4b8b-b7c2-ababf6d31ac3"), Level = 1, SpellId = Spells.Instances.PurifyFoodAndDrink.ID},
                    new StaveSpell { Id = Guid.Parse("db60a541-d1f4-4cd3-b5ab-b350318778be"), Level = 1, SpellId = Spells.Instances.UnseenServant.ID},
                    new StaveSpell { Id = Guid.Parse("446b0980-9410-466b-90ad-4d08ea8280da"), Level = 2, SpellId = Spells.Instances.Darkvision.ID},
                    new StaveSpell { Id = Guid.Parse("e2337185-9a72-4139-881c-bd36e6cf7570"), Level = 2, SpellId = Spells.Instances.EndureElements.ID},
                    new StaveSpell { Id = Guid.Parse("e184cb10-fe0e-4a71-81c0-370849d21ab3"), Level = 3, SpellId = Spells.Instances.Earthbind.ID},
                    new StaveSpell { Id = Guid.Parse("8f8dc8e7-506d-4fdd-be3e-2cbbe3084e2b"), Level = 3, SpellId = Spells.Instances.NeutralizePoison.ID},
                    new StaveSpell { Id = Guid.Parse("5d198132-d31d-4101-b9ed-da16b4a6c457"), Level = 3, SpellId = Spells.Instances.WanderersGuide.ID},
                    new StaveSpell { Id = Guid.Parse("465552cd-1ad9-4d15-95db-ac04989c5799"), Level = 4, SpellId = Spells.Instances.AirWalk.ID},
                    new StaveSpell { Id = Guid.Parse("f22e69f3-6fab-44d6-b835-dcde93f434b2"), Level = 4, SpellId = Spells.Instances.HallucinatoryTerrain.ID},
                    new StaveSpell { Id = Guid.Parse("3bd850d3-64a3-4715-af41-93a4ffc5dab0"), Level = 4, SpellId = Spells.Instances.RopeTrick.ID},
                    new StaveSpell { Id = Guid.Parse("dd152bb6-a7ce-4c27-a8a0-59edf5ec8c5c"), Level = 5, SpellId = Spells.Instances.PillarsOfSand.ID},
                    new StaveSpell { Id = Guid.Parse("c711a758-9588-46ee-b13e-9936531e925f"), Level = 5, SpellId = Spells.Instances.Veil.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("98080758-4d20-4a82-8a49-06c2e01e1d8d"),
                Name = "Staff of the Black Desert (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 950000,
                Level = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a2f58bdf-3fab-47f9-85da-07b3caf6240c"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8f84da64-8a7e-453b-a5e1-53c4f107fdec"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("d679e83c-8e7f-4d08-aa26-e99bd51bd060"), Level = 6, SpellId = Spells.Instances.PurpleWormSting.ID},
                    new StaveSpell { Id = Guid.Parse("9495bfc2-d799-4ebc-bb88-9df79bcdcc7c"), Level = 6, SpellId = Spells.Instances.SummonEntity.ID},
                    new StaveSpell { Id = Guid.Parse("7faa19cf-2866-40af-9a33-36ffbb6f1a99"), Level = 7, SpellId = Spells.Instances.BlightburnBlast.ID},
                    new StaveSpell { Id = Guid.Parse("0965fde0-27f2-470b-92be-de361f76e279"), Level = 7, SpellId = Spells.Instances.ControlSand.ID},
                    new StaveSpell { Id = Guid.Parse("88bf441c-ead2-41ec-8da2-2887895a947c"), Level = 7, SpellId = Spells.Instances.UnfetteredPack.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a885cf2a-c9e8-4bf7-a3ea-c20ff74465bd"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("5c679e01-970e-4910-a4a5-ac7e842b9946"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("f0772435-2700-4d68-8376-a3db77786dd4"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d591421b-ce4e-43e6-a249-fa977b4aae8f"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("254bcc34-be9c-48d9-845f-f341d64fe348"),
                SourceId = Sources.Instances.Pathfinder155.ID,
                Page = 76
            };
        }
    }
}
