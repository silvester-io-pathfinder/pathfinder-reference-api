using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Staves.Instances
{
    public class MentalistsStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("deb6c4dd-109d-43bf-9397-2f2b48e44053");

        protected override Stave GetStave()
        {
            return new Stave
            {
                Id = ID,
                Name = "Mentalist's Staff",
                Usage = "Held in 1 hand",
                Activate = "Cast a Spell.",
                CraftingRequirements = "Supply one casting of all listed levels of all listed spells.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("46bb791f-15df-4d28-8935-574c8372a59e"), Type = TextBlockType.Text, Text = "This polished wooden staff bears a swirling motif reminiscent of the folds of a brain. While wielding the staff, you gain a +2 circumstance bonus to checks to identify mental magic." };
        }

        protected override IEnumerable<ActionEffect> GetActionEffects()
        {
            yield return new ActionEffect
            {
                Id = Guid.Parse("896929a5-a3c7-48b8-8409-f9d25f02db6a"),
                Name = "Cast a Spell",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                Effects = new TextBlock[]
                {
                    new TextBlock { Id = Guid.Parse("583befd6-b2e5-43d6-95db-42635a3e6f33"), Type = TextBlockType.Text, Text = "You expend a number of charges from the staff to cast a spell from its list." }
                }
            };
        }

        protected override IEnumerable<StavePotencyBinding> GetPotencies()
        {
            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("4309d6fc-e69e-4a5a-b761-e358c5b5b2bf"),
                Price = 9000,
                ItemLevel = 4,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Unclassified.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("a71321ef-d5fa-4701-ada4-3c8b8c01fc34"), SpellId = Spells.Instances.Daze.ID},
                    new StaveSpell { Id = Guid.Parse("641bb342-18d3-4d0a-9daf-558564c695fa"), Level = 1, SpellId = Spells.Instances.Mindlink.ID},
                    new StaveSpell { Id = Guid.Parse("34eeb934-ab03-4e3e-9472-066d56fb548c"), Level = 1, SpellId = Spells.Instances.PhantomPain.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("d8711512-e53d-44b0-a438-ee04ef160189"),
                Price = 45000,
                ItemLevel = 8,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Greater.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("190870bd-61e2-4dc7-8bc6-a264a1d37167"), Level = 2, SpellId = Spells.Instances.Paranoia.ID},
                    new StaveSpell { Id = Guid.Parse("ce2b5b05-fbf4-4b5f-b819-424587b4bbf0"), Level = 3, SpellId = Spells.Instances.Hypercognition.ID},
                    new StaveSpell { Id = Guid.Parse("6f6b72fd-e48a-4a0f-9ea9-20e0689b6afa"), Level = 3, SpellId = Spells.Instances.PhantomPain.ID},
                },
            };

            yield return new StavePotencyBinding
            {
                Id = Guid.Parse("cfd69dcc-a85b-4660-9c81-a20901128aa4"),
                Price = 180000,
                ItemLevel = 12,
                BulkId = Bulks.Instances.OneBulk.ID,
                PotencyId = Potencies.Instances.Major.ID,
                Spells = new StaveSpell[]
                {
                    new StaveSpell { Id = Guid.Parse("cf5e0d52-8e12-427f-889a-0726b3f74348"), Level = 4, SpellId = Spells.Instances.ModifyMemory.ID},
                    new StaveSpell { Id = Guid.Parse("aef16f24-e2be-4320-ba2e-53cca9c82397"), Level = 4, SpellId = Spells.Instances.Telepathy.ID},
                    new StaveSpell { Id = Guid.Parse("7a23a1bd-094c-4ff9-b103-5ecb6bd63a0d"), Level = 5, SpellId = Spells.Instances.PhantomPain.ID},
                    new StaveSpell { Id = Guid.Parse("6ec92bb6-408a-4211-b7e1-50ee2d751848"), Level = 5, SpellId = Spells.Instances.SynapticPulse.ID},
                    new StaveSpell { Id = Guid.Parse("9e20a563-bcd2-474c-9da3-1007e9eacc04"), Level = 5, SpellId = Spells.Instances.Synesthesia.ID},
                },
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Staff.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c3fe7f7-bfe7-487a-b8c9-4ca5bc7ddb48"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 593
            };
        }
    }
}
