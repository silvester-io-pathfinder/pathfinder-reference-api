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
    public class StaffOfSieges : Template
    {
        public static readonly Guid ID = Guid.Parse("55e574b7-e8dc-4db3-8e07-75a7c8f236a0");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Sieges",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("d4835746-ba17-4c3a-ad28-eee3601d92a5"), "This adamantine staff is fitted with mithral plates resembling battlements on a castle. Lesser cover, cover, and greater cover don't grant any bonus against your spell attacks or to saving throws against your spells that you cast from the staff.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("7448e462-d5e7-4b14-aecb-ea63b4326cb2"),
                Name = "Staff of Sieges",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 6500000,
                Level = 20,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b95047dc-c2fb-47e8-acd7-80f969acf1d0"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8e34e91b-1f40-4b23-b424-37e50d1bdb73"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("df8d36f2-2e22-4dc8-b684-5678ee97d3cb"), SpellId = Spells.Instances.Shield.ID},
                    new StaveSpell { Id = Guid.Parse("ac09a20e-a62a-4886-8b27-dd1f2340f8a6"), SpellId = Spells.Instances.TelekineticProjectile.ID},
                    new StaveSpell { Id = Guid.Parse("34aebfb7-e20d-4b31-894e-dba3057af72b"), Level = 1, SpellId = Spells.Instances.GustOfWind.ID},
                    new StaveSpell { Id = Guid.Parse("988b7c53-1add-42d7-a706-7caff38de9df"), Level = 1, SpellId = Spells.Instances.Longstrider.ID},
                    new StaveSpell { Id = Guid.Parse("cf06757a-ab2b-4ca2-98e4-277c8fb6e02c"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                    new StaveSpell { Id = Guid.Parse("bb3ee59b-5e62-401f-9ea6-76489e2bf4a4"), Level = 2, SpellId = Spells.Instances.Web.ID},
                    new StaveSpell { Id = Guid.Parse("a57b77f2-05be-4393-9a37-4e8933a1379f"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("858e4ad0-df64-4914-84c9-7083ccc3bacd"), Level = 3, SpellId = Spells.Instances.WallOfWind.ID},
                    new StaveSpell { Id = Guid.Parse("8bf00996-234f-4cc3-b825-743f165a77ec"), Level = 4, SpellId = Spells.Instances.HallucinatoryTerrain.ID},
                    new StaveSpell { Id = Guid.Parse("351fe905-fbdf-44da-b253-861c777e8765"), Level = 4, SpellId = Spells.Instances.SolidFog.ID},
                    new StaveSpell { Id = Guid.Parse("d0c0bbcb-25f4-4fca-ac77-18e697386bbe"), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("7dd07dec-2091-4802-a56a-6b04c4f91a40"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("b12f01ed-cb3c-49e3-8750-bc3008479766"), Level = 5, SpellId = Spells.Instances.WallOfStone.ID},
                    new StaveSpell { Id = Guid.Parse("b4a1af5a-720d-4dbe-bc3b-cb942ed353fb"), Level = 6, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("a296eac3-3501-4720-ab3b-a87bab7f0a40"), Level = 6, SpellId = Spells.Instances.WallOfForce.ID},
                    new StaveSpell { Id = Guid.Parse("8b4fe53c-e7f1-4cee-b484-5d02e7462758"), Level = 7, SpellId = Spells.Instances.MagnificentMansion.ID},
                    new StaveSpell { Id = Guid.Parse("e0fd9c90-88b8-47ad-afb3-732887e06ce2"), Level = 7, SpellId = Spells.Instances.PrismaticSpray.ID},
                    new StaveSpell { Id = Guid.Parse("36dcdf41-4cca-444f-9160-4afe599dd8ff"), Level = 8, SpellId = Spells.Instances.Earthquake.ID},
                    new StaveSpell { Id = Guid.Parse("dc8bb6af-8e6d-40d3-bc08-d8daa941205a"), Level = 8, SpellId = Spells.Instances.ScintillatingPattern.ID},
                    new StaveSpell { Id = Guid.Parse("6f528ea6-0727-4b5c-9eca-8095a4be123d"), Level = 9, SpellId = Spells.Instances.MeteorSwarm.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7ede56b2-8be0-4db8-b856-664dcda155ee"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("60cf24b0-9d14-4d75-999c-6e2dcd1a0334"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("9e7c4db7-c69c-478a-ae53-a1759881a6e3"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("6c703dcd-e647-41f6-94b6-80787376d287"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d556bea-28d8-49ff-85ea-0d357b1b046d"),
                SourceId = Sources.Instances.Pathfinder156.ID,
                Page = 75
            };
        }
    }
}
