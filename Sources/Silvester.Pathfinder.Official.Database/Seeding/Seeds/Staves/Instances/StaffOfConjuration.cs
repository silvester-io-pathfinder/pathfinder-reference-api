using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfConjuration : Template
    {
        public static readonly Guid ID = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Conjuration",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Type = TextBlockType.Text, Text = "This ash staff is decorated with animals; wielding it, you gain a +2 circumstance bonus to checks to identify conjuration magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), SpellId = Spells.Instances.Tanglefoot.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 1, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 1, SpellId = Spells.Instances.UnseenServant.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 2, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 2, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 2, SpellId = Spells.Instances.SummonElemental.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 3, SpellId = Spells.Instances.StinkingCloud.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 3, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 3, SpellId = Spells.Instances.SummonElemental.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 4, SpellId = Spells.Instances.Creation.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 4, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 4, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 4, SpellId = Spells.Instances.SummonElemental.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 5, SpellId = Spells.Instances.BlackTentacles.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 5, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 5, SpellId = Spells.Instances.SummonElemental.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 6, SpellId = Spells.Instances.PhantomSteed.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 6, SpellId = Spells.Instances.SummonConstruct.ID},
                    new StaveSpell { Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"), Level = 6, SpellId = Spells.Instances.SummonElemental.ID},
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b419ba7-45ba-4c48-89d5-eefb8378d2be"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
