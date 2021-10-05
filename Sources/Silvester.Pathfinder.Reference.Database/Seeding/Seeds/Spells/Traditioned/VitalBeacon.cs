using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VitalBeacon : Template
    {
        public static readonly Guid ID = Guid.Parse("5f26aaa9-b610-4e1b-a10a-106f36f14f43");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Vital Beacon",
                Level = 4,
                CastTime = "1 minute.",
                Duration = "Until your next daily preparations.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09131262-ebb4-4b73-af25-6369b51e5d9a"), Type = TextBlockType.Text, Text = "Vitality radiates outward from you, allowing others to supplicate and receive healing. Once per round, either you or an ally can use an Interact action to supplicate and lay hands upon you to regain Hit Points. Each time the beacon heals someone, it decreases in strength. It restores 4d10 Hit Points to the first creature, 4d8 Hit Points to the second, 4d6 Hit Points to the third, and 4d4 Hit Points to the fourth, after which the spell ends. You can have only one vital beacon active at a time." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8df03f20-4342-468b-b477-93406c810fc5"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("37c26389-aa55-4a62-b493-55bcec390cbb"), Type = TextBlockType.Text, Text = "The beacon restores one additional die of Hit Points each time it heals, using the same die size as the others for that step." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e5b2afc-c77e-4259-bda6-24595fb42d03"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
