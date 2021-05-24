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
        public static readonly Guid ID = Guid.Parse("50a5910a-0be2-485a-8940-0720b1406d72");

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
            yield return new TextBlock { Id = Guid.Parse("057755af-3d7c-4222-9767-7aa122acbaa5"), Type = TextBlockType.Text, Text = "This simple iron staff is capped with a faceted, clear gem." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("ef514de4-ffa6-4fde-9e24-7b7e4fae49cd"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("7f22736e-23cf-4301-b199-5eb55da74e5b"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };

            yield return new ActionEffect
            {
                Id = Guid.Parse("7281f0ff-ae58-46fb-b8c5-7fc08db52563"),
                Name = "Interact",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("f5b3132f-32b6-4b7b-8479-cc5d3ec528dc"), Type = TextBlockType.Text, Text = "The gem at the top of the staff glows as a torch, shedding bright light in a 20-foot radius (and dim light to the next 20 feet) for 10 minutes." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("b64b7cf1-a3b0-407b-8238-8ee8588f3434"),
                Price = 42500,
                ItemLevel = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a24f75a4-37d8-495c-9238-5a6d8fc11406"), SpellId = Spells.Instances.Light.ID},
                    new StaveSpell { Id = Guid.Parse("33c6482b-bc8a-4089-8c56-19cbd3a90b49"), Level = 2, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("97e796a1-a0a7-4b0d-9ce3-650932d560e4"), Level = 3, SpellId = Spells.Instances.ContinualFlame.ID},
                    new StaveSpell { Id = Guid.Parse("37501cf6-d6ef-4344-a149-15adbaa2af01"), Level = 3, SpellId = Spells.Instances.SearingLight.ID},
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
                Id = Guid.Parse("0e3c1c05-3109-474b-b7a9-8c1d2f8fc2cc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 594
            };
        }
    }
}
