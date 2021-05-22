using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfAbjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Abjuration",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "This intricately carved wooden staff is warm to the touch and thrums with inner energy. While wielding the staff, you gain a +2 circumstance bonus to checks to identify abjuration magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse(""),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), SpellId = Spells.Instances.Shield.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.Alarm.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 1, SpellId = Spells.Instances.FeatherFall.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.EndureElements.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 2, SpellId = Spells.Instances.ResistEnergy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.Alarm.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 3, SpellId = Spells.Instances.GlyphOfWarding.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.DimensionalAnchor.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 4, SpellId = Spells.Instances.ResistEnergy.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse(""),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.Banishment.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 5, SpellId = Spells.Instances.EndureElements.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.DispelMagic.ID},
                    new StaveSpell { Id = Guid.Parse(""), Level = 6, SpellId = Spells.Instances.Repulsion.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
