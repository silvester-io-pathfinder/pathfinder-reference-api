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
    public class StaffOfNecromancy : Template
    {
        public static readonly Guid ID = Guid.Parse("0d2991dc-30ed-4fc9-8c61-7c21897a95ee");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Necromancy",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5ec547f0-1ed7-4cf3-bcb8-f9dd4d40e617"), "This twisted and grim-looking staff is adorned with hideous skull and bone motifs. While wielding the staff, you gain a +2 circumstance bonus to checks to identify necromancy magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("5af4ba1a-8ab8-4a7d-be9d-0b50e9d73533"),
                Name = "Staff of Necromancy",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("74d690b9-3dcf-4142-bea6-37539aa2f9dd"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c73718a9-f503-4981-8024-b59ec0eebca9"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("34c46fa8-70ca-456e-90e6-5505075ac23f"), SpellId = Spells.Instances.ChillTouch.ID},
                    new StaveSpell { Id = Guid.Parse("d83e9b92-3063-46f3-8e6d-50ba3802db38"), Level = 1, SpellId = Spells.Instances.GrimTendrils.ID},
                    new StaveSpell { Id = Guid.Parse("bb6ce92e-fe35-4fe6-8f83-3f6145f82515"), Level = 1, SpellId = Spells.Instances.RayOfEnfeeblement.ID},
                    new StaveSpell { Id = Guid.Parse("8d88aebd-77b0-40e0-a2a6-943fd073aa8c"), Level = 2, SpellId = Spells.Instances.Deafness.ID},
                    new StaveSpell { Id = Guid.Parse("d995f465-28a8-49ed-a8d9-92c6bc0682dc"), Level = 2, SpellId = Spells.Instances.GentleRepose.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("17cb7c4b-ab07-448f-99ef-1f880d38bd8a"),
                Name = "Staff of Necromancy (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 90000,
                Level = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("51e9141a-23f0-4fdc-9cb8-530710ec8f34"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("7fd29462-e189-4f21-87eb-23f15f53e25d"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("89082995-4fb6-4eeb-9df5-8b702031e40b"), Level = 3, SpellId = Spells.Instances.Blindness.ID},
                    new StaveSpell { Id = Guid.Parse("644da514-7bb2-4df8-960a-0a65e0f627e8"), Level = 3, SpellId = Spells.Instances.VampiricTouch.ID},
                    new StaveSpell { Id = Guid.Parse("ec10391a-342b-4753-9a97-c516bad112d1"), Level = 4, SpellId = Spells.Instances.GrimTendrils.ID},
                    new StaveSpell { Id = Guid.Parse("8fc982e7-8b4f-4734-90ac-bf780c6bbee6"), Level = 4, SpellId = Spells.Instances.VampiricTouch.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("41c68d38-eed4-428f-bc9e-e90152282b3a"),
                Name = "Staff of Necromancy (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("68becb45-e375-4920-affc-02acdc1f5f40"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("a6bfa273-0a13-49ed-886f-c5e9299da8cb"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("2b7b7427-5207-4c05-9913-8862fa9b52b8"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("de1dfd48-abec-4409-93fa-a1a0979aedb4"), Level = 5, SpellId = Spells.Instances.GentleRepose.ID},
                    new StaveSpell { Id = Guid.Parse("1e476290-711b-4cfa-adce-70f2f37562d6"), Level = 6, SpellId = Spells.Instances.GrimTendrils.ID},
                    new StaveSpell { Id = Guid.Parse("c1a529b5-d171-4002-8e33-70d0483bafd7"), Level = 6, SpellId = Spells.Instances.VampiricExsanguination.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("ef90e287-8b29-4a33-b9d0-4e72fa9dc825"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("1b8bc6f9-3101-4cd2-a133-aa401077fec1"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("907d3801-6227-4eae-b7da-2a80452acb1e"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9cb9137-259e-4e93-8bca-1a7f590ee806"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
