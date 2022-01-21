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
    public class StaffOfPower : Template
    {
        public static readonly Guid ID = Guid.Parse("06990eb6-99e6-4f28-a33c-dc1eadd99cf6");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Power",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("37ba2630-5ba5-49da-9af1-c5d9d555f2db"), "This staff of magically hardened wood is topped with a silver sculpture depicting magical runic symbols. When used as a weapon, a staff of power is a +2 greater striking staff.");;
            builder.Text(Guid.Parse("a6fa75b3-8fc3-4932-89fe-8b674917d80d"), "Voluntarily destroying a staff of power unleashes an incredible blast of energy. When wielding the staff, you can Interact to break it. This releases a 30-foot-burst magical explosion centered on the staff. This deals 2d8 force damage per charge remaining in the staff (DC 40 basic Reflex save). You automatically critically fail your save. A creature reduced to 0 Hit Points by this damage dies instantly; this is a death effect.");;
        }

        protected override IEnumerable<StaveVariant> GetStaveVariants()
        {
            yield return new StaveVariant
            {
                Id = Guid.Parse("8aa06e14-2a1e-4783-832e-9d5d75d95806"),
                Name = "Staff of Power",
                Usage = "Held in 1 hand",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
                Price = 1000000,
                Level = 16,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Standard.ID,
                RarityId = Rarities.Instances.Rare.ID,
                InlineActions = new InlineActionCollectionBuilder()
                    .Add(Guid.Parse("cbc8a323-0d6d-4e19-a4f3-01e96ded1a33"), ActionTypes.Instances.OneToThreeActions.ID, "Activate", action =>
                    {
                        action
                            .Kind("Cast a Spell")
                            .Details(details =>
                            {
                                details.Text(Guid.Parse("44f09290-4597-4229-92c5-0bad284ef183"), "You expend a number of charges from the staff to cast a spell from its list.");
                            });
                    })
                    .Build(),
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("cf264f54-c1b4-4152-8241-87c12e592d49"), Level = 1, SpellId = Spells.Instances.RayOfEnfeeblement.ID},
                    new StaveSpell { Id = Guid.Parse("e16c2750-2cab-4676-8338-cbf3a42a518c"), Level = 2, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("aaaa20b7-0792-4840-a42f-7570e774df8f"), Level = 3, SpellId = Spells.Instances.Levitate.ID},
                    new StaveSpell { Id = Guid.Parse("b6a6c666-7a11-4b07-b619-07c37f5a0eac"), Level = 4, SpellId = Spells.Instances.GlobeOfInvulnerability.ID},
                    new StaveSpell { Id = Guid.Parse("99847fc9-2b49-478c-b628-f834e42e49af"), Level = 4, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse("3cebb1d5-bbf0-4fd2-9a86-490364baa599"), Level = 5, SpellId = Spells.Instances.MagicMissile.ID},
                    new StaveSpell { Id = Guid.Parse("4cdf3c89-f5d8-4e90-99bc-b73494a5bd28"), Level = 6, SpellId = Spells.Instances.WallOfForce.ID},
                    new StaveSpell { Id = Guid.Parse("6051bc68-b6f6-4083-8257-dd144e5598e1"), Level = 7, SpellId = Spells.Instances.ConeOfCold.ID},
                    new StaveSpell { Id = Guid.Parse("9ff073f8-7b83-4621-861b-11cc9c25d6be"), Level = 7, SpellId = Spells.Instances.Fireball.ID},
                    new StaveSpell { Id = Guid.Parse("75c8631f-4b82-4be4-a0cc-980ad3d6bb09"), Level = 7, SpellId = Spells.Instances.LightningBolt.ID},
                },
            };
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("277c87ef-7f16-4e1c-b503-6849146d148f"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("89240e22-d183-41d3-97b3-a256225e05ec"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("670fa634-7fd8-4b26-ba63-8ec90165c506"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("78229fa9-41ec-4141-af17-005e8c57be24"), Traits.Instances.Staff.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("14672b72-6cb9-4c47-9639-230769b67059"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
