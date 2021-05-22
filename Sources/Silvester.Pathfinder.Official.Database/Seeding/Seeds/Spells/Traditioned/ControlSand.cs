using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ControlSand : Template
    {
        public static readonly Guid ID = Guid.Parse("9123b175-ae47-4b47-befc-fb57de128ca3");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Control Sand",
                Level = 7,
                Area = "5-foot emanation.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e3e596e-ede0-45c6-adbe-aa8a13fb7de2"), Type = TextBlockType.Text, Text = "You whip up a small sandstorm around your body. When a creature starts its turn in the area or moves into the area, it must succeed at a Fortitude save or become dazzled for as long as it remains in the area; it is then temporarily immune to this dazzling effect for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("6b482fdd-3b3f-481d-8e70-f5a7053892e5"), Type = TextBlockType.Text, Text = "Choose one of the following additional effects when you cast this spell. On subsequent rounds, you can switch to a different effect once per round as a free action triggered by sustaining the spell." };
            yield return new TextBlock { Id = Guid.Parse("15502b5f-65e4-40ee-a28e-ca87d6015ffb"), Type = TextBlockType.Enumeration, Text = "Sand Shield - You create a magical shield made of sand. The sand shield provides no benefit to AC, but it does allow you to use the Shield Block reaction and acts as a shield for this purpose. The sand shield has Hardness 14, 21 Hit Points, and no Broken Threshold; when the shield's HP are reduced to 0, you can't use its Shield Block reaction again until the next time you Sustain the Spell and choose the sand shield effect." };
            yield return new TextBlock { Id = Guid.Parse("00219cd1-5d3b-4e47-b9e0-218028d56b12"), Type = TextBlockType.Enumeration, Text = "Sandblast - You direct a jet of sand at a single target. One creature of your choice within 30 feet takes 8d6 slashing damage (basic Reflex save). On a critical failure, the creature is also dazzled for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("669ab3aa-e8df-4854-ac37-7dd6111d2a67"), Type = TextBlockType.Enumeration, Text = "Sandstorm - The area of the spell expands to a 30-foot emanation, and any creature that starts its turn in the area or moves into the area takes 6d4 slashing damage (basic Reflex save) and must hold its breath or begin suffocating." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("787c23dc-8b2f-4d64-a506-14acbd476ad3"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("fa6b30c7-f0a5-4dfb-a1fa-4f60d72c05aa"), Type = TextBlockType.Text, Text = "Increase the sand shield's Hardness by 2 and its Hit Points by 1, the sandblast damage by 1d6, and the sandstorm damage by 1d4." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85fd2fe9-f89c-46fb-b4a6-85144da6e87d"),
                SourceId = Sources.Instances.Pathfinder155.ID,
                Page = 73
            };
        }
    }
}
