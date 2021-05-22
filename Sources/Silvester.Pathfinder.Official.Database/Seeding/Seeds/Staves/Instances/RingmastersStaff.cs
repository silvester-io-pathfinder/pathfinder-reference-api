using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class RingmastersStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Ringmaster's Staff",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Type = TextBlockType.Text, Text = "This highly polished black wooden staff resembles an aristocrat’s oversized walking cane, complete with a silver head shaped like a large circus animal such as a horse or elephant. Ringmasters or announcers use ringmaster’s staves to draw attention from their audiences or to salvage acts that fall flat mid-performance. While wielding a ringmaster’s staff, your normal voice can be clearly heard by all creatures within 300 feet regardless of intervening barriers or ambient noise, although your voice can’t penetrate magical silence and you can’t use this to extend an auditory or sonic effect through barriers that would otherwise block it." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"),
                Price = 23000,
                ItemLevel = 6,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), SpellId = Spells.Instances.DancingLights.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 1, SpellId = Spells.Instances.FeatherFall.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 1, SpellId = Spells.Instances.FloatingDisk.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 2, SpellId = Spells.Instances.Glitterdust.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 2, SpellId = Spells.Instances.IllusoryCreature.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 2, SpellId = Spells.Instances.ObscuringMist.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"),
                Price = 180000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 3, SpellId = Spells.Instances.Enthrall.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 3, SpellId = Spells.Instances.Pyrotechnics.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 4, SpellId = Spells.Instances.FreedomOfMovement.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 4, SpellId = Spells.Instances.SummonAnimal.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 5, SpellId = Spells.Instances.CloakOfColors.ID},
                    new StaveSpell { Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"), Level = 5, SpellId = Spells.Instances.Command.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7386ec77-b30e-4a42-b3ba-3d226440206d"),
                SourceId = Sources.Instances.Pathfinder152.ID,
                Page = 74
            };
        }
    }
}
