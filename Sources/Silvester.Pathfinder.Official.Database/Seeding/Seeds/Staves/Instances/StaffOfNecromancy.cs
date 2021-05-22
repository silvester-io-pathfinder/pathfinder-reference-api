using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfNecromancy : Template
    {
        public static readonly Guid ID = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Necromancy",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Type = TextBlockType.Text, Text = "This twisted and grim-looking staff is adorned with hideous skull and bone motifs. While wielding the staff, you gain a +2 circumstance bonus to checks to identify necromancy magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), SpellId = Spells.Instances.ChillTouch.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 1, SpellId = Spells.Instances.GrimTendrils.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 1, SpellId = Spells.Instances.RayOfEnfeeblement.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 2, SpellId = Spells.Instances.Deafness.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 2, SpellId = Spells.Instances.GentleRepose.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"),
                Price = 90000,
                ItemLevel = 10,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 3, SpellId = Spells.Instances.Blindness.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 3, SpellId = Spells.Instances.VampiricTouch.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 4, SpellId = Spells.Instances.GrimTendrils.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 4, SpellId = Spells.Instances.VampiricTouch.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"),
                Price = 400000,
                ItemLevel = 14,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 5, SpellId = Spells.Instances.Cloudkill.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 5, SpellId = Spells.Instances.GentleRepose.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 6, SpellId = Spells.Instances.GrimTendrils.ID},
                    new StaveSpell { Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"), Level = 6, SpellId = Spells.Instances.VampiricExsanguination.ID},
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
                Id = Guid.Parse("62d08342-d64f-4074-8f68-b40f6191df00"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
