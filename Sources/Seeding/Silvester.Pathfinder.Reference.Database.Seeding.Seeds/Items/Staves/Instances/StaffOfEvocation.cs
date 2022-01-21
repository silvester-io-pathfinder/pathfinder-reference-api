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
    public class StaffOfEvocation : Template
    {
        public static readonly Guid ID = Guid.Parse("50e1e89d-8578-4fb9-a3c1-af9205a8968b");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Evocation",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("cdcb4e1f-d231-4398-bd53-48749e6bfdd2"), "This staff is tapered at the base and carved into a gem-studded twist at the top. While wielding the staff, you gain a +2 circumstance bonus to checks to identify evocation magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("18a13030-5e06-41ff-85ec-05ff4f57446f"),
                Name = "Staff of Evocation",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a2e1ce05-4024-47d5-9aa2-87440a6d1e07"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action => 
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("cfb951e0-134b-4b8a-9f00-09bf5cd2c052"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("83a71363-2e5e-4282-a984-2081ffad6078"), Level = 0, SpellId = Spells.Instances.RayOfFrost.ID},
                    new StaveSpell { Id = Guid.Parse("496acba8-a678-486f-b289-a738c48fee52"), Level = 1, SpellId = Spells.Instances.MagicMissile.ID},
                    new StaveSpell { Id = Guid.Parse("77b4a119-b634-4eb4-bda2-d6a2a1c73378"), Level = 1, SpellId = Spells.Instances.ShockingGrasp.ID},
                    new StaveSpell { Id = Guid.Parse("cf8cd988-4518-4ac3-bd76-3f20f4315217"), Level = 2, SpellId = Spells.Instances.AcidArrow.ID},
                    new StaveSpell { Id = Guid.Parse("d6488589-263d-49b9-9415-4fecb678b28e"), Level = 2, SpellId = Spells.Instances.Glitterdust.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("1947606f-246b-4fc5-9747-4c13a70d6b18"),
                Name = "Staff of Evocation (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("b1ddbc2b-d618-42af-a1ca-91a9d42099b6"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c18a9f5d-679c-4b09-8db6-f0a5c9b427a1"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("2ea66af8-09bc-477d-99d3-38658b08047d"), Level = 3, SpellId = Spells.Instances.LightningBolt.ID},
                    new StaveSpell { Id = Guid.Parse("2e1096a6-0af3-4747-b285-962b9a29c0cb"), Level = 3, SpellId = Spells.Instances.MagicMissile.ID},
                    new StaveSpell { Id = Guid.Parse("fbd44dd9-ddf3-4cf2-9873-1d4b6cc1d6d1"), Level = 4, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("a76496ee-4f4f-4fb2-9b28-eeb0905c524b"), Level = 4, SpellId = Spells.Instances.WeaponStorm.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("311692f9-5d68-41e1-9ed3-8c17419fe110"),
                Name = "Staff of Evocation (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("71ecd453-5830-475e-8903-ea884b66d82e"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("1f013b50-25fa-48f5-bf2c-c0862305b8cc"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("12831d87-904c-4e9a-a90a-c00a5daff8a4"), Level = 5, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse("a10033d1-e6e8-498e-be43-394d464ba554"), Level = 5, SpellId = Spells.Instances.MagicMissile.ID},
                    new StaveSpell { Id = Guid.Parse("5b1e0943-dbee-44d7-9a07-c006a3aec971"), Level = 6, SpellId = Spells.Instances.ChainLightning.ID},
                    new StaveSpell { Id = Guid.Parse("b537adba-bb50-4e53-ad0e-9a171d4b8b6a"), Level = 6, SpellId = Spells.Instances.WallOfForce.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("a80b5f17-70ab-4836-b40c-28b2c37b8d74"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("feed588c-6551-473f-8833-6ea1a048942a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("d1a4411c-1616-464c-b7b0-c31d2ced30ef"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f047c5e8-9cdb-4114-a54d-d923c60c187c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 593
            };
        }
    }
}
