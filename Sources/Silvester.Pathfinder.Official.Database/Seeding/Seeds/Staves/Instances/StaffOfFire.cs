using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
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
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("bebc6ba4-7e9e-42c5-b297-1d52a819747c"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("fd9f6edb-53b8-4e8a-8848-d18c81f94428"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("61a7357e-a2a4-42ae-a586-34e5e1ba21de"), Type = TextBlockType.Text, Text = "This staff resembles a blackened and burned length of ashen wood. It smells faintly of soot and glows as if lit by embers. You can use an Interact action to touch the tip of this staff to a torch, tinder, or a flammable substance to ignite a flame." };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("91954fdf-dc99-4a0d-a4ef-026056c12695"),
                Price = 6000,
                ItemLevel = 3,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("913f8c5d-bf78-4a26-b694-ee42141b7a6b"), SpellId = Spells.Instances.ProduceFlame.ID},
                    new StaveSpell { Id = Guid.Parse("62d6112b-7caf-4cae-8359-9479e1a6f346"), Level = 1, SpellId = Spells.Instances.BurningHands.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("e21a1207-9c22-4bda-ba64-5c26c06a4651"),
                Price = 45000,
                ItemLevel = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("b4eca8ec-3132-42a0-9f0b-083a444508f8"), Level = 2, SpellId = Spells.Instances.BurningHands.ID},
                    new StaveSpell { Id = Guid.Parse("918a7854-814a-4b24-a552-d389c2f34b1c"), Level = 2, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("d831bf6f-df88-4121-ae92-dd3b6b990cf5"), Level = 3, SpellId = Spells.Instances.FlamingSphere.ID},
                    new StaveSpell { Id = Guid.Parse("44f5e0b4-a590-42ed-9524-86b2e2c3fc3d"), Level = 3, SpellId = Spells.Instances.Fireball.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("0bb009ad-f038-4e03-b910-6e0f7b303d75"),
                Price = 180000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
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

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
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
