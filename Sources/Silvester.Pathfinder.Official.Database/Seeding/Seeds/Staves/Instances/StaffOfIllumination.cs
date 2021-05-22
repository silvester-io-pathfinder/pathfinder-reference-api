using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Staves.Instances
{
    public class StaffOfIllumination : Template
    {
        public static readonly Guid ID = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Staff of Illumination",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), Type = TextBlockType.Text, Text = "This simple iron staff is capped with a faceted, clear gem." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };

            yield return new ActionEffect
            {
                Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"),
                Name = "Interact",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), Type = TextBlockType.Text, Text = "The gem at the top of the staff glows as a torch, shedding bright light in a 20-foot radius (and dim light to the next 20 feet) for 10 minutes." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"),
                Price = 42500,
                ItemLevel = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), SpellId = Spells.Instances.Light.ID},
                    new StaveSpell { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), Level = 2, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), Level = 3, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"), Level = 3, SpellId = Spells.Instances.SearingLight.ID},
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
                Id = Guid.Parse("efc28cbf-ef78-48f0-967d-aec1b44d4d32"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
