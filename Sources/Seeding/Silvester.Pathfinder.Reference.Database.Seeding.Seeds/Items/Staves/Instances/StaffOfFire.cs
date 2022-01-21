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
    public class StaffOfFire : Template
    {
        public static readonly Guid ID = Guid.Parse("9798577c-6e68-4cd6-bf8c-bd9923a2e683");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Fire",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("61a7357e-a2a4-42ae-a586-34e5e1ba21de"), "This staff resembles a blackened and burned length of ashen wood. It smells faintly of soot and glows as if lit by embers. You can use an Interact action to touch the tip of this staff to a torch, tinder, or a flammable substance to ignite a flame.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("91954fdf-dc99-4a0d-a4ef-026056c12695"),
                Name = "Staff of Fire",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 6000,
                Level = 3,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("bc762c24-1969-415d-8ab9-e7e22cdc3e9d"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("ac0f03ea-8a55-4f95-afb1-d390d77b83a0"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("913f8c5d-bf78-4a26-b694-ee42141b7a6b"), SpellId = Spells.Instances.ProduceFlame.ID},
                    new StaveSpell { Id = Guid.Parse("62d6112b-7caf-4cae-8359-9479e1a6f346"), Level = 1, SpellId = Spells.Instances.BurningHands.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("e21a1207-9c22-4bda-ba64-5c26c06a4651"),
                Name = "Staff of Fire (Greater)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 45000,
                Level = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("dc7d7f63-fc4e-43e6-b6bd-df17d5af4b16"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("cd83f966-cbf5-425a-9d55-f645ab94a1a5"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("b4eca8ec-3132-42a0-9f0b-083a444508f8"), Level = 2, SpellId = Spells.Instances.BurningHands.ID},
                    new StaveSpell { Id = Guid.Parse("918a7854-814a-4b24-a552-d389c2f34b1c"), Level = 2, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("d831bf6f-df88-4121-ae92-dd3b6b990cf5"), Level = 3, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("44f5e0b4-a590-42ed-9524-86b2e2c3fc3d"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                },
            };

            yield return new StaveVariant
            {
                Id = Guid.Parse("0bb009ad-f038-4e03-b910-6e0f7b303d75"),
                Name = "Staff of Fire (Major)",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 180000,
                Level = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                RarityId = Rarities.Instances.Common.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("177271b0-6ab8-4744-8f13-9981111f10fb"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("f0ec80ea-2ce1-4064-930f-cbd2cb78c6c3"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("617ee4e1-3e21-4881-bb33-ba5c9677f7c6"), Level = 4, SpellId = Spells.Instances.FireShield.ID},
                    new StaveSpell { Id = Guid.Parse("60ebacd9-f157-4002-a62e-57ce49836ca5"), Level = 4, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("b86a1641-c80c-4728-828b-8be6b292daaa"), Level = 4, SpellId = Spells.Instances.WallOfFire.ID},
                    new StaveSpell { Id = Guid.Parse("27579629-7434-434d-9dd0-10ceab75d2c3"), Level = 5, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("faa015e5-2cb5-4001-aaa3-f1c0eab8d1ad"), Level = 5, SpellId = Spells.Instances.WallOfFire.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("72718b88-7f9c-46cf-926d-e22b0802f917"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("0c35962e-8cf8-4ef6-911d-fae1625d3c2a"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("312176cf-1e8e-43c2-a9c5-31075b915d99"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a32899a1-5eaa-4c9f-a323-7bb7c6803341"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
