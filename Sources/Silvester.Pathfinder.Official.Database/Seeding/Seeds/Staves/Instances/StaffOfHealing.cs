using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Healing",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Type = TextBlockType.Text, Text = "Made of smooth, white wood, this staff is capped at each end with a golden cross adorned with a multitude of ruby cabochons. A staff of healing grants an item bonus to the Hit Points you restore anytime you cast the heal spell using your own spell slots or using charges from the staff." };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"),
                Price = 9000,
                ItemLevel = 4,
                Addendum = "The item bonus granted to heal spells is +1.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), SpellId = Spells.Instances.Stabilize.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 1, SpellId = Spells.Instances.Heal.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"),
                Price = 47000,
                ItemLevel = 8,
                Addendum = "The item bonus granted to heal spells is +2.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 2, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 2, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 2, SpellId = Spells.Instances.RestoreSenses.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 3, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 3, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"),
                Price = 180000,
                ItemLevel = 12,
                Addendum = "The item bonus granted to heal spells is +3.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 4, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 4, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 5, SpellId = Spells.Instances.BreathOfLife.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 5, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 5, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"),
                Price = 920000,
                ItemLevel = 16,
                Addendum = "The item bonus granted to heal spells is +4.",
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.True.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 6, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 6, SpellId = Spells.Instances.Restoration.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 6, SpellId = Spells.Instances.RestoreSenses.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 7, SpellId = Spells.Instances.Heal.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 7, SpellId = Spells.Instances.Regenerate.ID},
                    new StaveSpell { Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"), Level = 7, SpellId = Spells.Instances.RemoveDisease.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04f16567-b23f-40e4-ba54-07a4a6e7cfa5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 595
            };
        }
    }
}
