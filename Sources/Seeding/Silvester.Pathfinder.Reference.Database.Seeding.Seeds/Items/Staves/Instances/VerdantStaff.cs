using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.Staves.Instances
{
    public class VerdantStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("a00e7823-576a-4c7e-91cc-7f3dc7b288e6");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Verdant Staff",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("74c3b504-4c48-47f3-b392-50b7a6ee42e9"), "This oak branch grows leaves in spring that change color in autumn and shed in winter. While wielding it, you gain a +2 circumstance bonus to Nature checks to identify plants.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("26164336-dc50-484b-ad35-5d30e7f5ee83"),
                Name = "Verdant Staff",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 22500,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("3521f267-db6f-45c2-9afb-30b2a85a43dc"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8513fd51-a9f4-4722-9193-5fec658e55ab"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("09efdca3-b5bb-453f-bd37-92c87064cca4"), SpellId = Spells.Instances.Tanglefoot.ID},
                    new StaveSpell { Id = Guid.Parse("2865df40-7196-4463-8de8-dcc49fbf240f"), Level = 1, SpellId = Spells.Instances.Shillelagh.ID},
                    new StaveSpell { Id = Guid.Parse("3e6196fc-74e6-4561-acf9-86e4084582fc"), Level = 2, SpellId = Spells.Instances.Barkskin.ID},
                    new StaveSpell { Id = Guid.Parse("563c6473-06b9-4edc-b981-2e779d1f19c2"), Level = 2, SpellId = Spells.Instances.Entangle.ID},
                    new StaveSpell { Id = Guid.Parse("5c030b98-5e06-4229-ab4d-64c41bfde474"), Level = 2, SpellId = Spells.Instances.ShapeWood.ID},
                    new StaveSpell { Id = Guid.Parse("82a84714-c217-49e1-bc23-f66e01db9970"), Level = 2, SpellId = Spells.Instances.TreeShape.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("2a2c4b14-3838-4b3b-a32d-f978eb055f56"),
                Name = "Verdant Staff (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 175000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("c02c4a5c-d816-4951-af24-1e14fd451dec"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("b72704ad-4da7-4ef2-a5a7-5951bf23fa49"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a11141a1-0587-41ff-95b7-fd2893740326"), Level = 3, SpellId = Spells.Instances.WallOfThorns.ID},
                    new StaveSpell { Id = Guid.Parse("f56cd5ac-ed58-4d6d-bf85-53b51fc31f5e"), Level = 4, SpellId = Spells.Instances.Barkskin.ID},
                    new StaveSpell { Id = Guid.Parse("5bbc0c6a-0441-4f3a-94b1-7776330a9b75"), Level = 4, SpellId = Spells.Instances.SpeakWithPlants.ID},
                    new StaveSpell { Id = Guid.Parse("773416d7-8b4d-4e67-b46c-85768948f236"), Level = 5, SpellId = Spells.Instances.PlantForm.ID},
                    new StaveSpell { Id = Guid.Parse("dde7f63e-c6e9-4032-859c-d0a49743f2f4"), Level = 5, SpellId = Spells.Instances.WallOfThorns.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7db73b03-b133-42cd-a765-b01f362cc613"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("72149703-9e19-4c51-9b4f-14c1f79a0dbe"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("98845cb9-4fea-43c0-949e-d68db7df9b6c"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("af4fdec4-a45b-4077-8c21-ecb8cae3f4c7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
