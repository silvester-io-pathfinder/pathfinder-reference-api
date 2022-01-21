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
    public class RingmastersStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("7bb4740b-c530-49e3-97ad-e2bec15a475a");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Ringmaster's Staff"
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("5b455a3e-bf03-4535-8d20-f89e675fd6a1"), "This highly polished black wooden staff resembles an aristocrat's oversized walking cane, complete with a silver head shaped like a large circus animal such as a horse or elephant. Ringmasters or announcers use ringmaster's staves to draw attention from their audiences or to salvage acts that fall flat mid-performance. While wielding a ringmaster's staff, your normal voice can be clearly heard by all creatures within 300 feet regardless of intervening barriers or ambient noise, although your voice can't penetrate magical silence and you can't use this to extend an auditory or sonic effect through barriers that would otherwise block it.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("442af870-83a9-4683-b487-da0d99efe4c3"),
                Name = "Ringmaster's Staff",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 23000,
                Level = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("9f42c517-9b81-49cc-96a9-b49c61929617"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("5c610799-31c7-4bed-9226-20797dca997b"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("fc7228ba-b217-46d1-8081-782b4624b4a7"), SpellId = Spells.Instances.DancingLights.ID},
                    new StaveSpell { Id = Guid.Parse("b4454fff-48f1-4a1a-85c0-75d15421acb8"), Level = 1, SpellId = Spells.Instances.FeatherFall.ID},
                    new StaveSpell { Id = Guid.Parse("674b230b-dc7a-4c45-8f05-4acd5d9a12b4"), Level = 1, SpellId = Spells.Instances.FloatingDisk.ID},
                    new StaveSpell { Id = Guid.Parse("148c1d9b-82a3-4f29-9415-fb03986e5f15"), Level = 2, SpellId = Spells.Instances.Glitterdust.ID},
                    new StaveSpell { Id = Guid.Parse("001aa7db-5923-4317-ac7b-770649f7d0e8"), Level = 2, SpellId = Spells.Instances.IllusoryCreature.ID},
                    new StaveSpell { Id = Guid.Parse("e49e27bc-56f4-4277-be58-c31e7dfa72ce"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("d554b39e-b86e-4412-ae00-bba60c39f1c2"),
                Name = "Ringmaster's Staff (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 180000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("fa06ddd6-d25c-4c44-904e-49e8c9412f96"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("8116d655-175c-4cb6-99cd-76d548623754"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("017aa1e5-2eaa-409a-b4ae-21615875bdfb"), Level = 3, SpellId = Spells.Instances.Enthrall.ID},
                    new StaveSpell { Id = Guid.Parse("5087bcdc-52ac-4f8e-867a-cd59b42255e0"), Level = 3, SpellId = Spells.Instances.Pyrotechnics.ID},
                    new StaveSpell { Id = Guid.Parse("9d632902-c2d1-446b-9131-c17999e05698"), Level = 4, SpellId = Spells.Instances.FreedomOfMovement.ID},
                    new StaveSpell { Id = Guid.Parse("891a3a80-313a-44c7-9fc0-9d1b5947c155"), Level = 4, SpellId = Spells.Instances.SummonAnimal.ID},
                    new StaveSpell { Id = Guid.Parse("ad417a4b-0312-4e20-a14e-8220e1524302"), Level = 5, SpellId = Spells.Instances.CloakOfColors.ID},
                    new StaveSpell { Id = Guid.Parse("63430769-6400-40fb-a3b8-9db3790b7b50"), Level = 5, SpellId = Spells.Instances.Command.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("7b6c9ce3-624c-45c9-8fac-d66985fda743"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7789725e-a26d-42d5-931c-03c47d04df88"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("5f329929-c505-48bd-af51-71f139bff9ca"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("648fd2e2-b743-4a92-9149-1022622398a0"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fe62b2a-bc2f-4eb0-b008-0a74aac38cbb"),
                SourceId = Sources.Instances.Pathfinder152.ID,
                Page = 74
            };
        }
    }
}
