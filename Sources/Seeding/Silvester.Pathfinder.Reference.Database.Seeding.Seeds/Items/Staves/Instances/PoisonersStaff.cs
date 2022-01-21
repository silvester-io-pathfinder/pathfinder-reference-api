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
    public class PoisonersStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("e9e7ca52-dbd8-438f-929f-366dc6667216");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Poisoner's Staff",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("1a6f52bb-1aec-4fb2-8444-b7b84ca5776d"), "This gnarled staff is covered with thorns and coated with a glistening lacquer that acts as a minor irritant. While holding the staff, you aren't affected by its coating or thorns, and you reduce the DC of your flat checks to overcome persistent poison damage.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("08c086bc-5e66-4625-b599-c15fba313c6e"),
                Name = "Poisoner's Staff",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 9000,
                Level = 4,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("d1209988-cb48-4e68-a7d7-2011da8d3ed4"), "You reduce the DC of your flat checks to overcome persistent poison damage from 15 to 13.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("5db182fe-b6d6-4a49-96a3-8a3dee1d5071"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("5a88c9c1-202e-48e0-9594-a6febf7ad88c"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("6ce967af-1ad7-4d94-bb56-284d48cf6c0d"), SpellId = Spells.Instances.Guidance.ID},
                    new StaveSpell { Id = Guid.Parse("e643c8fe-ed1a-4fed-86ac-c49f56b881a9"), Level = 1, SpellId = Spells.Instances.DetectPoison.ID},
                    new StaveSpell { Id = Guid.Parse("755230b3-2199-4a12-89f4-a354d1856f17"), Level = 1, SpellId = Spells.Instances.SpiderSting.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("a76fbb8c-4863-4408-9246-ea95d9abb287"),
                Name = "Poisoner's Staff (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 45000,
                Level = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("f76a1180-f933-4c56-afb5-ebc164ca8240"), "You reduce the DC of your flat checks to overcome persistent poison damage from 15 to 10.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("dcb9299f-ee87-4176-8d62-bf99332b3fef"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("57f6d954-e092-44b0-b1e7-4e25a46b002d"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("4724fd20-4831-440e-a50f-96bca28f5c6d"), Level = 2, SpellId = Spells.Instances.EnhanceVictuals.ID},
                    new StaveSpell { Id = Guid.Parse("fc7fe6c0-bcc3-4f3c-9479-6d282f9cf5e7"), Level = 2, SpellId = Spells.Instances.ImpSting.ID},
                    new StaveSpell { Id = Guid.Parse("66460ee2-a85a-4daa-a2db-c752dcf41499"), Level = 3, SpellId = Spells.Instances.NeutralizePoison.ID},
                    new StaveSpell { Id = Guid.Parse("a7a7b5e4-2a52-4957-bea9-23ab1e78af09"), Level = 3, SpellId = Spells.Instances.StinkingCloud.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("d1fcf415-ca61-40e9-ab27-b6662d453142"),
                Name = "Poisoner's Staff (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 400000,
                Level = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                Addendum = new TextBlockBuilder()
                    .Text(Guid.Parse("3c00d772-d54d-4b8d-ac34-7ed9d0e772d0"), "You reduce the DC of your flat checks to overcome persistent poison damage from 15 to 5.")
                    .Build(),
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("22b896fd-bedc-4af5-97c2-4b33836ff73b"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("db757bfd-b5f3-41a5-b088-c3553a2f1924"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("3195dae1-145d-473f-8e14-8f2c1752be68"), Level = 4, SpellId = Spells.Instances.SwarmingWaspStings.ID},
                    new StaveSpell { Id = Guid.Parse("59120307-5ae3-4e21-85ec-c46f5c836311"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("df261ced-c571-4389-af60-6f8ce831c622"), Level = 6, SpellId = Spells.Instances.PurpleWormSting.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("aabe3d34-e9dd-485f-bcca-2f47b32361de"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("ef120200-7861-4f3c-97e5-1f65b5755dbc"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8407b7e3-4735-4aa9-9f27-677fd07212ef"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("9f8eb9d2-2cd0-4d68-9a06-dae9b8711ec7"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("559e08a1-1dc0-493b-95f9-fc9078f95029"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8ac2256-373c-4c84-8b3e-7456db5d2144"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
