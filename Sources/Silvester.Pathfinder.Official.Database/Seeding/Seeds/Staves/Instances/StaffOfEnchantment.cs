using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfEnchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Enchantment",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Type = TextBlockType.Text, Text = "A mesmerizing gemstone caps the head of this handsomely crafted wooden staff. While wielding the staff, you gain a +2 circumstance bonus to checks to identify enchantment magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 1, SpellId = Spells.Instances.Charm.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 1, SpellId = Spells.Instances.Command.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 2, SpellId = Spells.Instances.HideousLaughter.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 2, SpellId = Spells.Instances.TouchOfIdiocy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 3, SpellId = Spells.Instances.Paralyze.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 4, SpellId = Spells.Instances.Charm.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 4, SpellId = Spells.Instances.Confusion.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 4, SpellId = Spells.Instances.Suggestion.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 5, SpellId = Spells.Instances.Command.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 5, SpellId = Spells.Instances.CrushingDespair.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 6, SpellId = Spells.Instances.Dominate.ID},
                    new StaveSpell { Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"), Level = 6, SpellId = Spells.Instances.Feeblemind.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa2a4c56-c5f6-424c-be6b-f73a7e7fe7be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
