using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
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
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cf003da9-73d4-4a5d-a143-0b141793d64f"), Type = TextBlockType.Text, Text = "his rough metal staff is pitted and sandblasted, with thousands of nigh-imperceptible sand crystals embedded in its surface. While carrying the staff, you gain a +2 circumstance bonus to Occultism checks to identify aberrations and oozes native to the Darklands." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("12086751-cbc3-4014-9acc-62c17315edf5"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("dc02bbc9-9d8f-4ece-963f-8581bb6634c3"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("44596169-1982-4729-b441-22bda806c8e4"),
                Price = 185000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
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

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("98080758-4d20-4a82-8a49-06c2e01e1d8d"),
                Price = 950000,
                ItemLevel = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
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

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
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
