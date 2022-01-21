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
    public class StaffOfIllumination : Template
    {
        public static readonly Guid ID = Guid.Parse("50a5910a-0be2-485a-8940-0720b1406d72");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Illumination",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("057755af-3d7c-4222-9767-7aa122acbaa5"), "This simple iron staff is capped with a faceted, clear gem.");;
        }
        
        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("b64b7cf1-a3b0-407b-8238-8ee8588f3434"),
                Name = "Staff of Illumination",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 42500,
                Level = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("f1d26717-9353-48c9-86da-e52fb5c2f827"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8df4b91c-0b82-4fc4-b57f-776d358edba4"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Add(Guid.Parse("007171fd-6129-4b7b-aebe-c5f88a1f0e8d"), ActionTypes.Instances.OneAction.ID, "Activate", action => 
                    {
                        action
                            .Kind("Interact")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("fcadc2d3-5882-48b3-afee-ef9cad2e793f"), "The gem at the top of the staff glows as a torch, shedding bright light in a 20-foot radius (and dim light to the next 20 feet) for 10 minutes.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a24f75a4-37d8-495c-9238-5a6d8fc11406"), SpellId = Spells.Instances.Light.ID},
                    new StaveSpell { Id = Guid.Parse("33c6482b-bc8a-4089-8c56-19cbd3a90b49"), Level = 2, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("97e796a1-a0a7-4b0d-9ce3-650932d560e4"), Level = 3, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("37501cf6-d6ef-4344-a149-15adbaa2af01"), Level = 3, SpellId = Spells.Instances.SearingLight.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("949a6c44-315e-4e0f-9786-92fc2bde98b9"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f4b8e768-07d2-49bf-bfa9-3e7ef7e7cd24"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("f66cc0dd-e1ab-403c-9b48-fc9aac225ff9"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e3c1c05-3109-474b-b7a9-8c1d2f8fc2cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
