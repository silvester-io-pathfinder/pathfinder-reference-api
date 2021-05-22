using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ScintillatingSafeguard : Template
    {
        public static readonly Guid ID = Guid.Parse("43379e31-324a-464c-9c6f-095fddcdcf31");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Scintillating Safeguard",
                Level = 6,
                Range = "30 feet.",
                Targets = "Up to 5 willing creatures who would be harmed by the triggering effect.",
                Trigger = "An effect would deal physical or energy damage to you or a creature in range.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }
        
        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6dc2e100-44e5-4de3-909a-6c0ef2dba1c8"), Type = TextBlockType.Text, Text = "A sparkling magical barrier envelops each target, shielding them against the triggering effect. Choose one type of physical or energy damage the triggering effect deals. Each target gains resistance 10 against that damage type for the triggering effect. The resistance applies only against the initial damage, not against any persistent damage or other lingering effects of the effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e7a08d35-29ec-4134-8437-8a69e8e9cfd8"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e29a2981-8197-40ce-8072-a4bf776a0c57"), Type = TextBlockType.Text, Text = "The resistance increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("606216b0-f7f5-4383-8ecf-fc3431edd477"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 224
            };
        }
    }
}
