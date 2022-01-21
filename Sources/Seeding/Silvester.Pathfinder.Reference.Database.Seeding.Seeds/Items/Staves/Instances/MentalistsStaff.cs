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
    public class MentalistsStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("deb6c4dd-109d-43bf-9397-2f2b48e44053");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Mentalist's Staff"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("46bb791f-15df-4d28-8935-574c8372a59e"), "This polished wooden staff bears a swirling motif reminiscent of the folds of a brain. While wielding the staff, you gain a +2 circumstance bonus to checks to identify mental magic.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("4309d6fc-e69e-4a5a-b761-e358c5b5b2bf"),
                Name = "Mentalist's Staff",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 9000,
                Level = 4,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("931310ad-43a2-4895-954a-43361c5de92a"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("7a5c083f-bc8a-40e0-9986-08fe46f8d1e2"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a71321ef-d5fa-4701-ada4-3c8b8c01fc34"), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse("641bb342-18d3-4d0a-9daf-558564c695fa"), Level = 1, SpellId = Spells.Instances.Mindlink.ID},
                    new StaveSpell { Id = Guid.Parse("34eeb934-ab03-4e3e-9472-066d56fb548c"), Level = 1, SpellId = Spells.Instances.PhantomPain.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("d8711512-e53d-44b0-a438-ee04ef160189"),
                Name = "Mentalist's Staff (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 45000,
                Level = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("6c0e0672-e244-4bf3-b65d-f88f95465b4f"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("c42fca85-e4a1-40e1-bf4f-5ee04c213054"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("190870bd-61e2-4dc7-8bc6-a264a1d37167"), Level = 2, SpellId = Spells.Instances.Paranoia.ID},
                    new StaveSpell { Id = Guid.Parse("ce2b5b05-fbf4-4b5f-b819-424587b4bbf0"), Level = 3, SpellId = Spells.Instances.Hypercognition.ID},
                    new StaveSpell { Id = Guid.Parse("6f6b72fd-e48a-4a0f-9ea9-20e0689b6afa"), Level = 3, SpellId = Spells.Instances.PhantomPain.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("cfd69dcc-a85b-4660-9c81-a20901128aa4"),
                Name = "Mentalist's Staff (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 180000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("a45aff7b-64a9-41f7-9f1c-78714094897c"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("ee872fa4-c7fc-49bc-8855-74373390597c"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("cf5e0d52-8e12-427f-889a-0726b3f74348"), Level = 4, SpellId = Spells.Instances.ModifyMemory.ID},
                    new StaveSpell { Id = Guid.Parse("aef16f24-e2be-4320-ba2e-53cca9c82397"), Level = 4, SpellId = Spells.Instances.Telepathy.ID},
                    new StaveSpell { Id = Guid.Parse("7a23a1bd-094c-4ff9-b103-5ecb6bd63a0d"), Level = 5, SpellId = Spells.Instances.PhantomPain.ID},
                    new StaveSpell { Id = Guid.Parse("6ec92bb6-408a-4211-b7e1-50ee2d751848"), Level = 5, SpellId = Spells.Instances.SynapticPulse.ID},
                    new StaveSpell { Id = Guid.Parse("9e20a563-bcd2-474c-9da3-1007e9eacc04"), Level = 5, SpellId = Spells.Instances.Synesthesia.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("0456a369-4737-44a7-8036-050edd44bb03"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("7f569b74-d4e0-42dc-b4ae-d60f33079ffe"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("09f28922-aec1-4614-9532-b5ce5f498ee8"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c3fe7f7-bfe7-487a-b8c9-4ca5bc7ddb48"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 593
            };
        }
    }
}
